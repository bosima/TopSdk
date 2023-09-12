using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatScencegroupMessageSendV2Response.
    /// </summary>
    public class OapiImChatScencegroupMessageSendV2Response : DingTalkResponse
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
        /// 开发消息ID
        /// </summary>
        [XmlElement("open_msg_id")]
        public string OpenMsgId { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("succ")]
        public bool Succ { get; set; }

    }
}
