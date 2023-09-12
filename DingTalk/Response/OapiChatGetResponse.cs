using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiChatGetResponse.
    /// </summary>
    public class OapiChatGetResponse : DingTalkResponse
    {
        /// <summary>
        /// chat_info
        /// </summary>
        [XmlElement("chat_info")]
        public ChatInfoDomain ChatInfo { get; set; }

        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

	/// <summary>
/// ChatInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ChatInfoDomain : TopObject
{
	        /// <summary>
	        /// agentidlist
	        /// </summary>
	        [XmlArray("agentidlist")]
	        [XmlArrayItem("string")]
	        public List<string> Agentidlist { get; set; }
	
	        /// <summary>
	        /// 是否全员禁用 0 不禁言 1 全员禁言
	        /// </summary>
	        [XmlElement("chatBannedType")]
	        public long ChatBannedType { get; set; }
	
	        /// <summary>
	        /// conversationTag
	        /// </summary>
	        [XmlElement("conversationTag")]
	        public long ConversationTag { get; set; }
	
	        /// <summary>
	        /// extidlist
	        /// </summary>
	        [XmlArray("extidlist")]
	        [XmlArrayItem("string")]
	        public List<string> Extidlist { get; set; }
	
	        /// <summary>
	        /// 群头像mediaId
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 仅群主和群管理员可管理 0否 1 是
	        /// </summary>
	        [XmlElement("managementType")]
	        public long ManagementType { get; set; }
	
	        /// <summary>
	        /// 尽群主和管理员可@所有人 0 否 1 是
	        /// </summary>
	        [XmlElement("mentionAllAuthority")]
	        public long MentionAllAuthority { get; set; }
	
	        /// <summary>
	        /// name
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// owner
	        /// </summary>
	        [XmlElement("owner")]
	        public string Owner { get; set; }
	
	        /// <summary>
	        /// 是否可以搜索群名 0 不可以 1可以搜索
	        /// </summary>
	        [XmlElement("searchable")]
	        public long Searchable { get; set; }
	
	        /// <summary>
	        /// 新成员可查看聊天历史 0否 1是
	        /// </summary>
	        [XmlElement("showHistoryType")]
	        public long ShowHistoryType { get; set; }
	
	        /// <summary>
	        /// 群状态 1-正常 2-已解散
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// useridlist
	        /// </summary>
	        [XmlArray("useridlist")]
	        [XmlArrayItem("string")]
	        public List<string> Useridlist { get; set; }
	
	        /// <summary>
	        /// 入群需群主或群管理员同意 0不需要 1需要
	        /// </summary>
	        [XmlElement("validationType")]
	        public long ValidationType { get; set; }
}

    }
}
