using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Top.Api.Util
{
    internal sealed class AsyncWebUtils
    {
        private int _timeout = 20000;
        private int _readWriteTimeout = 60000;
        private bool _ignoreSSLCheck = true;
        private bool _disableWebProxy = false;
        private readonly object _lock = new object();
        private HttpClient _httpClient;

        /// <summary>
        /// 等待请求开始返回的超时时间
        /// </summary>
        public int Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        /// <summary>
        /// 等待读取数据完成的超时时间
        /// </summary>
        public int ReadWriteTimeout
        {
            get { return this._readWriteTimeout; }
            set { this._readWriteTimeout = value; }
        }

        /// <summary>
        /// 是否忽略SSL检查
        /// </summary>
        public bool IgnoreSSLCheck
        {
            get { return this._ignoreSSLCheck; }
            set { this._ignoreSSLCheck = value; }
        }

        /// <summary>
        /// 是否禁用本地代理
        /// </summary>
        public bool DisableWebProxy
        {
            get { return this._disableWebProxy; }
            set { this._disableWebProxy = value; }
        }

        private HttpClient GetHttpClient()
        {
            if (_httpClient == null)
            {
                lock (_lock)
                {
                    if (_httpClient == null)
                    {
                        // https://github.com/TalAloni/StandardSocketsHttpHandler
                        var handler = new StandardSocketsHttpHandler
                        {
                            PooledConnectionLifetime = TimeSpan.FromMinutes(3), // Recreate every 3 minutes
                            ConnectTimeout = TimeSpan.FromMilliseconds(_timeout),
                            ResponseDrainTimeout = TimeSpan.FromMilliseconds(_readWriteTimeout),
                            UseProxy = _disableWebProxy,
                        };

                        if (this._ignoreSSLCheck)
                        {
                            handler.SslOptions.RemoteCertificateValidationCallback = new RemoteCertificateValidationCallback(TrustAllValidationCallback);
                        }

                        _httpClient = new HttpClient(handler);
                    }
                }
            }

            return _httpClient;
        }

        /// <summary>
        /// 执行HTTP GET请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求文本参数</param>
        /// <returns>HTTP响应</returns>
        public Task<string> DoGetAsync(string url, IDictionary<string, string> textParams)
        {
            return DoGetAsync(url, textParams, null);
        }

        /// <summary>
        /// 执行HTTP GET请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求文本参数</param>
        /// <param name="headerParams">请求头部参数</param>
        /// <returns>HTTP响应</returns>
        public async Task<string> DoGetAsync(string url, IDictionary<string, string> textParams, IDictionary<string, string> headerParams)
        {
            if (textParams != null && textParams.Count > 0)
            {
                url = BuildRequestUrl(url, textParams);
            }

            var uri = new Uri(url);
            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = uri,
            };
            requestMessage.Headers.UserAgent.ParseAdd("top-sdk-net");
            requestMessage.Headers.ExpectContinue = false;
            requestMessage.Headers.Accept.ParseAdd("text/xml");
            requestMessage.Headers.Accept.ParseAdd("text/javascript");

            if (headerParams != null)
            {
                foreach (var header in headerParams)
                {
                    requestMessage.Headers.Add(header.Key, header.Value);
                }
            }

            var response = await GetHttpClient().SendAsync(requestMessage);
            response.EnsureSuccessStatusCode();
            return await GetResponseAsStringAsync(response);
        }

        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求文本参数</param>
        /// <returns>HTTP响应</returns>
        public Task<string> DoPostAsync(string url, IDictionary<string, string> textParams)
        {
            return DoPostAsync(url, textParams, null);
        }

        /// <summary>
        /// 执行带文件上传的HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求文本参数</param>
        /// <param name="fileParams">请求文件参数</param>
        /// <param name="headerParams">请求头部参数</param>
        /// <returns>HTTP响应</returns>
        public async Task<string> DoPostAsync(string url, IDictionary<string, string> textParams, IDictionary<string, FileItem> fileParams, IDictionary<string, string> headerParams)
        {
            // 如果没有文件参数，则走普通POST请求
            if (fileParams == null || fileParams.Count == 0)
            {
                return await DoPostAsync(url, textParams, headerParams);
            }

            string boundary = DateTime.Now.Ticks.ToString("X"); // 随机分隔线
            MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent(boundary);
            multipartFormDataContent.Headers.ContentType.CharSet = "utf-8";

            // 组装文本请求参数
            if (textParams != null)
            {
                foreach (KeyValuePair<string, string> kv in textParams)
                {
                    multipartFormDataContent.Add(new StringContent(kv.Value), kv.Key);
                }
            }

            // 组装文件请求参数
            foreach (KeyValuePair<string, FileItem> kv in fileParams)
            {
                string key = kv.Key;
                FileItem fileItem = kv.Value;
                if (!fileItem.IsValid())
                {
                    throw new ArgumentException("FileItem is invalid");
                }

                using (MemoryStream stream = new MemoryStream())
                {
                    fileItem.Write(stream);
                    var fileContent = new ByteArrayContent(stream.ToArray());
                    fileContent.Headers.Add("Content-Type", fileItem.GetMimeType());
                    fileContent.Headers.Add("Content-Disposition", $"form-data; name =\"{key}\";filename=\"{fileItem.GetFileName()}\"");
                    multipartFormDataContent.Add(fileContent);
                }
            }

            var uri = new Uri(url);
            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = uri,
                Content = multipartFormDataContent,
            };

            requestMessage.Headers.UserAgent.ParseAdd("top-sdk-net");
            requestMessage.Headers.ExpectContinue = false;
            requestMessage.Headers.Accept.ParseAdd("text/xml");
            requestMessage.Headers.Accept.ParseAdd("text/javascript");

            if (headerParams != null)
            {
                foreach (var header in headerParams)
                {
                    requestMessage.Headers.Add(header.Key, header.Value);
                }
            }

            var response = await GetHttpClient().SendAsync(requestMessage);
            response.EnsureSuccessStatusCode();
            return await GetResponseAsStringAsync(response);
        }

        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求文本参数</param>
        /// <param name="headerParams">请求头部参数</param>
        /// <returns>HTTP响应</returns>
        public async Task<string> DoPostAsync(string url, IDictionary<string, string> textParams, IDictionary<string, string> headerParams)
        {
            FormUrlEncodedContent formUrlEncodedContent = new FormUrlEncodedContent(textParams);

            var uri = new Uri(url);
            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = uri,
                Content = formUrlEncodedContent,
            };

            requestMessage.Headers.UserAgent.ParseAdd("top-sdk-net");
            requestMessage.Headers.ExpectContinue = false;
            requestMessage.Headers.Accept.ParseAdd("text/xml");
            requestMessage.Headers.Accept.ParseAdd("text/javascript");

            if (headerParams != null)
            {
                foreach (var header in headerParams)
                {
                    requestMessage.Headers.Add(header.Key, header.Value);
                }
            }

            var response = await GetHttpClient().SendAsync(requestMessage);
            response.EnsureSuccessStatusCode();
            return await GetResponseAsStringAsync(response);
        }

        /// <summary>
        /// 调用请求
        /// content type: application/json
        /// </summary>
        /// <returns>The post with json.</returns>
        /// <param name="url">URL.</param>
        /// <param name="textParams">Text parameters.</param>
        /// <param name="headerParams">Header parameters.</param>
        public async Task<string> DoPostWithJsonAsync(string url, IDictionary<string, Object> textParams, IDictionary<string, string> headerParams)
        {
            String body = TopUtils.ObjectToJson(textParams, new FastJSON.JSONParameters() { UseApiNamingStyle = false, UseExtensions = false, SerializeNullValues = false });
            StringContent formUrlEncodedContent = new StringContent(body);
            formUrlEncodedContent.Headers.ContentType.MediaType = "application/json";
            formUrlEncodedContent.Headers.ContentType.CharSet = "utf-8";

            var uri = new Uri(url);
            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = uri,
                Content = formUrlEncodedContent,
            };

            requestMessage.Headers.UserAgent.ParseAdd("top-sdk-net");
            requestMessage.Headers.ExpectContinue = false;
            requestMessage.Headers.Accept.ParseAdd("text/xml");
            requestMessage.Headers.Accept.ParseAdd("text/javascript");

            if (headerParams != null)
            {
                foreach (var header in headerParams)
                {
                    requestMessage.Headers.Add(header.Key, header.Value);
                }
            }

            var response = await GetHttpClient().SendAsync(requestMessage);
            response.EnsureSuccessStatusCode();
            return await GetResponseAsStringAsync(response);
        }

        /// <summary>
        /// 组装含参数的请求URL。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数映射</param>
        /// <returns>带参数的请求URL</returns>
        public static string BuildRequestUrl(string url, IDictionary<string, string> parameters)
        {
            if (parameters != null && parameters.Count > 0)
            {
                return BuildRequestUrl(url, BuildQuery(parameters));
            }
            return url;
        }

        /// <summary>
        /// 组装含参数的请求URL。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queries">一个或多个经过URL编码后的请求参数串</param>
        /// <returns>带参数的请求URL</returns>
        public static string BuildRequestUrl(string url, params string[] queries)
        {
            if (queries == null || queries.Length == 0)
            {
                return url;
            }

            StringBuilder newUrl = new StringBuilder(url);
            bool hasQuery = url.Contains("?");
            bool hasPrepend = url.EndsWith("?") || url.EndsWith("&");

            foreach (string query in queries)
            {
                if (!string.IsNullOrEmpty(query))
                {
                    if (!hasPrepend)
                    {
                        if (hasQuery)
                        {
                            newUrl.Append("&");
                        }
                        else
                        {
                            newUrl.Append("?");
                            hasQuery = true;
                        }
                    }
                    newUrl.Append(query);
                    hasPrepend = false;
                }
            }
            return newUrl.ToString();
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildQuery(IDictionary<string, string> parameters)
        {
            if (parameters == null || parameters.Count == 0)
            {
                return null;
            }

            StringBuilder query = new StringBuilder();
            bool hasParam = false;

            foreach (KeyValuePair<string, string> kv in parameters)
            {
                string name = kv.Key;
                string value = kv.Value;
                // 忽略参数名或参数值为空的参数
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
                {
                    if (hasParam)
                    {
                        query.Append("&");
                    }

                    query.Append(name);
                    query.Append("=");
                    query.Append(HttpUtility.UrlEncode(value, Encoding.UTF8));
                    hasParam = true;
                }
            }

            return query.ToString();
        }

        private static bool TrustAllValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; // 忽略SSL证书检查
        }

        /// <summary>
        /// 把响应流转换为文本。
        /// </summary>
        /// <param name="rsp">响应流对象</param>
        /// <returns>响应文本</returns>
        private async Task<string> GetResponseAsStringAsync(HttpResponseMessage rsp)
        {
            Stream stream = null;
            StreamReader reader = null;

            try
            {
                // 以字符流的方式读取HTTP响应
                stream = await rsp.Content.ReadAsStreamAsync();
                if (Constants.CONTENT_ENCODING_GZIP.Equals(rsp.Content.Headers.ContentEncoding.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    stream = new GZipStream(stream, CompressionMode.Decompress);
                }

                string charset = rsp.Content.Headers.ContentType.CharSet;
                if (string.IsNullOrEmpty(charset))
                {
                    charset = Constants.CHARSET_UTF8;
                }
                var encoding = Encoding.GetEncoding(charset);

                reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null && rsp.Content != null) rsp.Content.Dispose();
            }
        }
    }
}
