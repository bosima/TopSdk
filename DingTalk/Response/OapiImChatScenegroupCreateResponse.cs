using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatScenegroupCreateResponse.
    /// </summary>
    public class OapiImChatScenegroupCreateResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public OpenSceneGroupCreateResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenSceneGroupCreateResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenSceneGroupCreateResponseDomain : TopObject
{
	        /// <summary>
	        /// 会话id
	        /// </summary>
	        [XmlElement("chat_id")]
	        public string ChatId { get; set; }
	
	        /// <summary>
	        /// 开放群id
	        /// </summary>
	        [XmlElement("open_conversation_id")]
	        public string OpenConversationId { get; set; }
}

    }
}
