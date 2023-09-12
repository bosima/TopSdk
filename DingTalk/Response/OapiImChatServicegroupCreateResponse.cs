using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatServicegroupCreateResponse.
    /// </summary>
    public class OapiImChatServicegroupCreateResponse : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ServiceGroupCreateResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ServiceGroupCreateResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ServiceGroupCreateResponseDomain : TopObject
{
	        /// <summary>
	        /// 开放的会话chatId
	        /// </summary>
	        [XmlElement("chat_id")]
	        public string ChatId { get; set; }
	
	        /// <summary>
	        /// 开放的会话ID
	        /// </summary>
	        [XmlElement("open_conversation_id")]
	        public string OpenConversationId { get; set; }
	
	        /// <summary>
	        /// 群链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

    }
}
