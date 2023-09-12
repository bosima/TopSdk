using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpChatbotListorgbotbytypeandbottypeResponse.
    /// </summary>
    public class CorpChatbotListorgbotbytypeandbottypeResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// ChatbotModelDomain Data Structure.
/// </summary>
[Serializable]

public class ChatbotModelDomain : TopObject
{
	        /// <summary>
	        /// 机器人类型
	        /// </summary>
	        [XmlElement("bot_type")]
	        public long BotType { get; set; }
	
	        /// <summary>
	        /// 机器人简介
	        /// </summary>
	        [XmlElement("breif")]
	        public string Breif { get; set; }
	
	        /// <summary>
	        /// 机器人id
	        /// </summary>
	        [XmlElement("chatbot_id")]
	        public long ChatbotId { get; set; }
	
	        /// <summary>
	        /// 企业corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 机器人详细描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 机器人头像
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// microappAgentId
	        /// </summary>
	        [XmlElement("microapp_agent_id")]
	        public long MicroappAgentId { get; set; }
	
	        /// <summary>
	        /// 机器人名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// outgoingToken
	        /// </summary>
	        [XmlElement("outgoing_token")]
	        public string OutgoingToken { get; set; }
	
	        /// <summary>
	        /// outgoingURL
	        /// </summary>
	        [XmlElement("outgoing_url")]
	        public string OutgoingUrl { get; set; }
	
	        /// <summary>
	        /// 钉钉分配的type
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
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
	        [XmlArray("result_list")]
	        [XmlArrayItem("chatbot_model")]
	        public List<ChatbotModelDomain> ResultList { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
