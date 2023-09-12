using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DingTalk.Api;
using FastJSON;
using System.Threading.Tasks;
using System.Xml;
using Top.Api.Parser;
using Top.Api.Util;

namespace Top.Api.DingTalk
{
    public class AsyncDefaultDingTalkClient : IAsyncDingTalkClient
    {
        internal string serverUrl;
        internal string format = Constants.FORMAT_XML;
        internal DateTime dt1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0);

        internal AsyncWebUtils asyncWebUtils;
        internal ITopLogger topLogger;
        internal bool disableParser = false; // 禁用响应结果解释
        internal bool disableTrace = false; // 禁用日志调试功能
        internal bool useSimplifyJson = false; // 是否采用精简化的JSON返回
        internal bool useGzipEncoding = true;  // 是否启用响应GZIP压缩
        internal bool useJsonString = false; // 是否采用JsonString生成
        internal IDictionary<string, string> systemParameters; // 设置所有请求共享的系统级参数

        #region DefaultDingTalkClient Constructors

        public AsyncDefaultDingTalkClient(string serverUrl)
        {
            this.serverUrl = serverUrl;
            this.asyncWebUtils = new AsyncWebUtils();
            this.topLogger = Top.Api.Log.Instance;
        }

        public AsyncDefaultDingTalkClient(string serverUrl, string format)
            : this(serverUrl)
        {
            this.format = format;
        }

        #endregion

        public void SetTimeout(int timeout)
        {
            this.asyncWebUtils.Timeout = timeout;
        }

        public void SetReadWriteTimeout(int readWriteTimeout)
        {
            this.asyncWebUtils.ReadWriteTimeout = readWriteTimeout;
        }

        public void SetDisableParser(bool disableParser)
        {
            this.disableParser = disableParser;
        }

        public void SetDisableTrace(bool disableTrace)
        {
            this.disableTrace = disableTrace;
        }

        public void SetUseSimplifyJson(bool useSimplifyJson)
        {
            this.useSimplifyJson = useSimplifyJson;
        }

        public void SetUseGzipEncoding(bool useGzipEncoding)
        {
            this.useGzipEncoding = useGzipEncoding;
        }

        public void SetIgnoreSSLCheck(bool ignore)
        {
            this.asyncWebUtils.IgnoreSSLCheck = ignore;
        }

        public void SetSystemParameters(IDictionary<string, string> systemParameters)
        {
            this.systemParameters = systemParameters;
        }

        #region IDingTalkClient Members

        public virtual Task<T> ExecuteAsync<T>(IDingTalkRequest<T> request) where T : DingTalkResponse
        {
            return DoExecuteAsync<T>(request, null, DateTime.Now);
        }

        public virtual Task<T> ExecuteAsync<T>(IDingTalkRequest<T> request, string session) where T : DingTalkResponse
        {
            return DoExecuteAsync<T>(request, session, DateTime.Now);
        }

        public virtual Task<T> ExecuteAsync<T>(IDingTalkRequest<T> request, string session, DateTime timestamp) where T : DingTalkResponse
        {
            return DoExecuteAsync<T>(request, session, timestamp);
        }

        public Task<T> ExecuteAsync<T>(IDingTalkRequest<T> request, string accessKey, string accessSecret) where T : DingTalkResponse
        {
            return ExecuteAsync<T>(request, accessKey, accessSecret, null, null);
        }

        public Task<T> ExecuteAsync<T>(IDingTalkRequest<T> request, string accessKey, string accessSecret, string suiteTicket) where T : DingTalkResponse
        {
            return ExecuteAsync<T>(request, accessKey, accessSecret, suiteTicket, null);
        }

        public Task<T> ExecuteAsync<T>(IDingTalkRequest<T> request, string accessKey, string accessSecret, string suiteTicket, string corpId) where T : DingTalkResponse
        {
            if (request.GetApiCallType() == null || request.GetApiCallType().Equals(DingTalkConstants.CALL_TYPE_TOP))
            {
                throw new NotImplementedException();
            }
            else
            {
                return DoExecuteOApiAsync(request, null, accessKey, accessSecret, suiteTicket, corpId, DateTime.Now);
            }
        }

        #endregion

        private Task<T> DoExecuteAsync<T>(IDingTalkRequest<T> request, string session, DateTime timestamp) where T : DingTalkResponse
        {
            if (request.GetApiCallType() == null || request.GetApiCallType().Equals(DingTalkConstants.CALL_TYPE_TOP))
            {
                throw new NotImplementedException();
            }
            else
            {
                return DoExecuteOApiAsync(request, session, null, null, null, null, timestamp);
            }
        }

        private async Task<T> DoExecuteOApiAsync<T>(IDingTalkRequest<T> request, string session, string accessKey, string accessSecret, string suiteTicket, string corpId, DateTime timestamp) where T : DingTalkResponse
        {
            long start = DateTime.Now.Ticks;

            // 提前检查业务参数
            try
            {
                request.Validate();
            }
            catch (TopException e)
            {
                return CreateErrorResponse<T>(e.ErrorCode, e.ErrorMsg);
            }

            this.format = Constants.FORMAT_JSON;

            // 添加协议级请求参数
            TopDictionary txtParams = new TopDictionary(request.GetParameters());
            txtParams.Add(DingTalkConstants.ACCESS_TOKEN, session);

            // 添加头部参数
            if (this.useGzipEncoding)
            {
                request.GetHeaderParameters()[Constants.ACCEPT_ENCODING] = Constants.CONTENT_ENCODING_GZIP;
            }

            string realServerUrl = null;
            // 签名优先
            if (accessKey != null)
            {
                long dingTimestamp = GetTimestamp(DateTime.UtcNow);
                // 验证签名有效性
                String canonicalString = DingTalkSignatureUtil.GetCanonicalStringForIsv(dingTimestamp, suiteTicket);
                String signature = DingTalkSignatureUtil.ComputeSignature(accessSecret, canonicalString);
                IDictionary<String, String> ps = new Dictionary<String, String>();
                ps.Add("accessKey", accessKey);
                ps.Add("signature", signature);
                ps.Add("timestamp", dingTimestamp + "");
                if (suiteTicket != null)
                {
                    ps.Add("suiteTicket", suiteTicket);
                }
                if (corpId != null)
                {
                    ps.Add("corpId", corpId);
                }

                String queryStr = DingTalkSignatureUtil.ParamToQueryString(ps, "utf-8");
                if (this.serverUrl.IndexOf("?") > 0)
                {
                    realServerUrl = this.serverUrl + "&" + queryStr;
                }
                else
                {
                    realServerUrl = this.serverUrl + "?" + queryStr;
                }
            }
            else
            {
                if (this.serverUrl.IndexOf("?") > 0)
                {
                    realServerUrl = this.serverUrl + (session != null && session != "" ? ("&access_token=" + session) : "");
                }
                else
                {
                    realServerUrl = this.serverUrl + (session != null && session != "" ? ("?access_token=" + session) : "");
                }
            }

            try
            {
                string body;

                if (request.GetHttpMethod() == "POST")
                {
                    if (request is IDingTalkUploadRequest<T>) // 是否需要上传文件
                    {
                        IDingTalkUploadRequest<T> uRequest = (IDingTalkUploadRequest<T>)request;
                        IDictionary<string, FileItem> fileParams = TopUtils.CleanupDictionary(uRequest.GetFileParameters());
                        body = await asyncWebUtils.DoPostAsync(realServerUrl, null, fileParams, request.GetHeaderParameters());
                    }
                    else
                    {
                        IDictionary<String, Object> jsonParams = new Dictionary<String, Object>();
                        foreach (string key in request.GetParameters().Keys)
                        {
                            string value = request.GetParameters()[key];
                            if (useJsonString)
                            {
                                jsonParams.Add(key, value);
                            }
                            else
                            {
                                if (value.StartsWith("[") && value.EndsWith("]"))
                                {
                                    IList childMap = (IList)TopUtils.JsonToObject(value);
                                    jsonParams.Add(key, childMap);
                                }
                                else if (value.StartsWith("{") && value.EndsWith("}"))
                                {
                                    IDictionary<string, Object> childMap = (IDictionary<string, Object>)TopUtils.JsonToObject(value);
                                    jsonParams.Add(key, childMap);
                                }
                                else
                                {
                                    jsonParams.Add(key, value);
                                }
                            }
                        }


                        body = await asyncWebUtils.DoPostWithJsonAsync(realServerUrl, jsonParams, request.GetHeaderParameters());
                    }
                }
                else
                {
                    body = await asyncWebUtils.DoGetAsync(realServerUrl, request.GetParameters());
                }

                // 解释响应结果
                T rsp;
                if (disableParser)
                {
                    rsp = Activator.CreateInstance<T>();
                    rsp.Body = body;
                }
                else
                {
                    ITopParser<T> tp = new DingTalkJsonParser<T>();
                    rsp = tp.Parse(body);
                }

                // 追踪错误的请求
                if (rsp.IsError)
                {
                    TimeSpan latency = new TimeSpan(DateTime.Now.Ticks - start);
                    TraceApiError(request.GetApiName(), serverUrl, txtParams, latency.TotalMilliseconds, rsp.Body);
                }
                return rsp;
            }
            catch (Exception e)
            {
                TimeSpan latency = new TimeSpan(DateTime.Now.Ticks - start);
                TraceApiError(request.GetApiName(), serverUrl, txtParams, latency.TotalMilliseconds, e.GetType() + ": " + e.Message);
                throw e;
            }
        }

        internal virtual string GetServerUrl(string serverUrl, string apiName, string session)
        {
            return serverUrl;
        }

        internal virtual string GetSdkVersion()
        {
            return Constants.SDK_VERSION;
        }

        internal T CreateErrorResponse<T>(string errCode, string errMsg) where T : DingTalkResponse
        {
            T rsp = Activator.CreateInstance<T>();
            rsp.ErrCode = errCode;
            rsp.ErrMsg = errMsg;

            if (Constants.FORMAT_XML.Equals(format))
            {
                XmlDocument root = new XmlDocument();
                XmlElement bodyE = root.CreateElement(Constants.ERROR_RESPONSE);
                XmlElement codeE = root.CreateElement(Constants.ERROR_CODE);
                codeE.InnerText = errCode;
                bodyE.AppendChild(codeE);
                XmlElement msgE = root.CreateElement(Constants.ERROR_MSG);
                msgE.InnerText = errMsg;
                bodyE.AppendChild(msgE);
                root.AppendChild(bodyE);
                rsp.Body = root.OuterXml;
            }
            else
            {
                IDictionary<string, object> errObj = new Dictionary<string, object>();
                errObj.Add(Constants.ERROR_CODE, errCode);
                errObj.Add(Constants.ERROR_MSG, errMsg);
                IDictionary<string, object> root = new Dictionary<string, object>();
                root.Add(Constants.ERROR_RESPONSE, errObj);

                string body = JSON.ToJSON(root);
                rsp.Body = body;
            }
            return rsp;
        }

        internal void TraceApiError(string apiName, string url, Dictionary<string, string> parameters, double latency, string errorMessage)
        {
            if (!disableTrace)
            {
                this.topLogger.TraceApiError("dingtalk", apiName, url, parameters, latency, errorMessage);
            }
        }

        private long GetTimestamp(DateTime dateTime)
        {
            return (dateTime.Ticks - dt1970.Ticks) / 10000;
        }
    }
}
