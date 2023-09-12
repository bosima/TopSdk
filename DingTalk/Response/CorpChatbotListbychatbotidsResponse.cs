using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpChatbotListbychatbotidsResponse.
    /// </summary>
    public class CorpChatbotListbychatbotidsResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// ChatbotResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class ChatbotResultVoDomain : TopObject
{
	        /// <summary>
	        /// 0-正常，1-只服务端可管理
	        /// </summary>
	        [XmlElement("authority")]
	        public long Authority { get; set; }
	
	        /// <summary>
	        /// 2-企业对内机器人，3-企业对外机器人
	        /// </summary>
	        [XmlElement("bot_type")]
	        public long BotType { get; set; }
	
	        /// <summary>
	        /// 机器人简介
	        /// </summary>
	        [XmlElement("breif")]
	        public string Breif { get; set; }
	
	        /// <summary>
	        /// 机器人chatbotId
	        /// </summary>
	        [XmlElement("chatbot_id")]
	        public string ChatbotId { get; set; }
	
	        /// <summary>
	        /// 机器人详细介绍
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// INCOMING = 1,OUTGOING = 2,INOUT = 3
	        /// </summary>
	        [XmlElement("function")]
	        public long Function { get; set; }
	
	        /// <summary>
	        /// 机器人头像
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 向群添加机器人时是否可改头像：0-不可必，1-可改
	        /// </summary>
	        [XmlElement("icon_mdify")]
	        public long IconMdify { get; set; }
	
	        /// <summary>
	        /// 手机端是否能添加机器人：0-移动端不能加，1-移动端能添加
	        /// </summary>
	        [XmlElement("mobile_switch")]
	        public long MobileSwitch { get; set; }
	
	        /// <summary>
	        /// 机器人名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 向群添加机器人时是否可改名字：0-不可必，1-可改
	        /// </summary>
	        [XmlElement("name_modify")]
	        public long NameModify { get; set; }
	
	        /// <summary>
	        /// 是否支持单聊：0-不要单聊，1需要单聊
	        /// </summary>
	        [XmlElement("oto_support")]
	        public long OtoSupport { get; set; }
	
	        /// <summary>
	        /// 机器人消息回调时在header中添加的token,用于对钉钉鉴权
	        /// </summary>
	        [XmlElement("outgoing_token")]
	        public string OutgoingToken { get; set; }
	
	        /// <summary>
	        /// 机器人回调地址
	        /// </summary>
	        [XmlElement("outgoing_url")]
	        public string OutgoingUrl { get; set; }
	
	        /// <summary>
	        /// 机器人预览图
	        /// </summary>
	        [XmlElement("preview_media_id")]
	        public string PreviewMediaId { get; set; }
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
	        [XmlArrayItem("chatbot_result_vo")]
	        public List<ChatbotResultVoDomain> ResultList { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
