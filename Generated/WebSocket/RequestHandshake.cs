#region MIT License
/**
 * RequestHandshake.cs
 *
 * The MIT License
 *
 * Copyright (c) 2012 sta.blockhead
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
#endregion

using System;
using System.Collections.Specialized;
using System.Text;
using WebSocketSharp.Net;

namespace WebSocketSharp
{

    public class RequestHandshake : Handshake
    {
        #region Private Field

        private NameValueCollection _queryString;

        #endregion

        #region Private Constructor

        private RequestHandshake()
        {
        }

        #endregion

        #region Public Constructor

        public RequestHandshake(string uriString)
        {
            HttpMethod = "GET";
            RequestUri = Ext.ToUri(uriString);

            AddHeader("Upgrade", "websocket");
            AddHeader("Connection", "Upgrade");
        }

        #endregion

        #region Properties

        public string HttpMethod { get; private set; }

        public bool IsWebSocketRequest
        {

            get
            {
                if (HttpMethod != "GET")
                    return false;

                if (ProtocolVersion != HttpVersion.Version11)
                    return false;

                if (!HeaderExists("Upgrade", "websocket"))
                    return false;

                if (!HeaderExists("Connection", "Upgrade"))
                    return false;

                if (!HeaderExists("Host"))
                    return false;

                if (!HeaderExists("Sec-WebSocket-Key"))
                    return false;

                if (!HeaderExists("Sec-WebSocket-Version"))
                    return false;

                return true;
            }
        }

        public NameValueCollection QueryString
        {
            get
            {
                if (_queryString == null)
                {
                    _queryString = new NameValueCollection();

                    var i = RawUrl.IndexOf('?');
                    if (i > 0)
                    {
                        var query = RawUrl.Substring(i + 1);
                        var components = query.Split('&');
                        foreach (var c in components)
                        {
                            var nv = Ext.GetNameAndValue(c, "=");
                            if (nv.Key != null)
                            {
                                var name = Ext.UrlDecode(nv.Key);
                                var val = Ext.UrlDecode(nv.Value);
                                _queryString.Add(name, val);
                            }
                        }
                    }
                }

                return _queryString;
            }
        }

        public string RawUrl
        {
            get
            {
                if (RequestUri.IsAbsoluteUri)
                    return RequestUri.PathAndQuery;

                return RequestUri.OriginalString;
            }
        }

        public Uri RequestUri { get; private set; }

        #endregion

        #region Public Static Methods

        public static RequestHandshake Parse(WebSocketContext context)
        {
            return new RequestHandshake
            {
                Headers = context.Headers,
                HttpMethod = "GET",
                RequestUri = context.RequestUri,
                ProtocolVersion = HttpVersion.Version11
            };
        }

        public static RequestHandshake Parse(string[] request)
        {
            var requestLine = request[0].Split(' ');
            if (requestLine.Length != 3)
            {
                var msg = "Invalid HTTP Request-Line: " + request[0];
                throw new ArgumentException(msg, "request");
            }

            var headers = new WebHeaderCollection();
            for (int i = 1; i < request.Length; i++)
                headers.Add(request[i]);

            return new RequestHandshake
            {
                Headers = headers,
                HttpMethod = requestLine[0],
                RequestUri = Ext.ToUri(requestLine[1]),
                ProtocolVersion = new Version(requestLine[2].Substring(5))
            };
        }

        #endregion

        #region Public Method

        public override string ToString()
        {
            var buffer = new StringBuilder();
            buffer.AppendFormat("{0} {1} HTTP/{2}{3}", HttpMethod, RawUrl, ProtocolVersion, _crlf);
            foreach (string key in Headers.AllKeys)
                buffer.AppendFormat("{0}: {1}{2}", key, Headers[key], _crlf);

            buffer.Append(_crlf);
            return buffer.ToString();
        }

        #endregion
    }
}