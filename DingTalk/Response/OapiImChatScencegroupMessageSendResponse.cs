using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatScencegroupMessageSendResponse.
    /// </summary>
    public class OapiImChatScencegroupMessageSendResponse : DingTalkResponse
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
        /// 成功
        /// </summary>
        [XmlElement("succ")]
        public bool Succ { get; set; }

    }
}
