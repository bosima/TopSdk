using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasUserSubaccountDeleteResponse.
    /// </summary>
    public class OapiImpaasUserSubaccountDeleteResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码  -1 系统异常 40035 参数错误
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 接口是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
