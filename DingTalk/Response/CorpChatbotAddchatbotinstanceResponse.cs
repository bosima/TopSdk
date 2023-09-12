using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpChatbotAddchatbotinstanceResponse.
    /// </summary>
    public class CorpChatbotAddchatbotinstanceResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// ChatbotInstanceVoDomain Data Structure.
/// </summary>
[Serializable]

public class ChatbotInstanceVoDomain : TopObject
{
	        /// <summary>
	        /// 机器人实例userId
	        /// </summary>
	        [XmlElement("chatbot_user_id")]
	        public string ChatbotUserId { get; set; }
	
	        /// <summary>
	        /// 机器人发消息时的地址
	        /// </summary>
	        [XmlElement("webhook")]
	        public string Webhook { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlElement("result")]
	        public ChatbotInstanceVoDomain Result { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
