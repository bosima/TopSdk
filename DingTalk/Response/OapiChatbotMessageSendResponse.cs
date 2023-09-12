using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiChatbotMessageSendResponse.
    /// </summary>
    public class OapiChatbotMessageSendResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public OtoMessageResponeModelDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OtoMessageResponeModelDomain Data Structure.
/// </summary>
[Serializable]

public class OtoMessageResponeModelDomain : TopObject
{
	        /// <summary>
	        /// 加密的消息id
	        /// </summary>
	        [XmlElement("message_id")]
	        public string MessageId { get; set; }
}

    }
}
