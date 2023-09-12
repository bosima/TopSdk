using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatScencegroupInteractivecardSendResponse.
    /// </summary>
    public class OapiImChatScencegroupInteractivecardSendResponse : DingTalkResponse
    {
        /// <summary>
        /// 统一错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 业务结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
