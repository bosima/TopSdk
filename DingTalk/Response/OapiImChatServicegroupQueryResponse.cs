using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatServicegroupQueryResponse.
    /// </summary>
    public class OapiImChatServicegroupQueryResponse : DingTalkResponse
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
        public ServiceGroupQueryResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ServiceGroupQueryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ServiceGroupQueryResponseDomain : TopObject
{
	        /// <summary>
	        /// 管理员数量
	        /// </summary>
	        [XmlElement("admin_count")]
	        public long AdminCount { get; set; }
	
	        /// <summary>
	        /// 全部成员数量
	        /// </summary>
	        [XmlElement("member_count")]
	        public long MemberCount { get; set; }
	
	        /// <summary>
	        /// 开放的会话id
	        /// </summary>
	        [XmlElement("open_conversation_id")]
	        public string OpenConversationId { get; set; }
	
	        /// <summary>
	        /// 群标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 群链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

    }
}
