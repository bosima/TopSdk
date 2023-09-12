using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatbotGetResponse.
    /// </summary>
    public class OapiImChatbotGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 开放的机器人实例列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("chatbot_instance_v_o")]
        public List<ChatbotInstanceVODomain> Result { get; set; }

	/// <summary>
/// ChatbotInstanceVODomain Data Structure.
/// </summary>
[Serializable]

public class ChatbotInstanceVODomain : TopObject
{
	        /// <summary>
	        /// 机器人userId
	        /// </summary>
	        [XmlElement("chatbot_user_id")]
	        public string ChatbotUserId { get; set; }
}

    }
}
