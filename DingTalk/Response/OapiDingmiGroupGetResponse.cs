using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingmiGroupGetResponse.
    /// </summary>
    public class OapiDingmiGroupGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 结果码消息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public GroupChatDataResultDomain Result { get; set; }

        /// <summary>
        /// 服务是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }

	/// <summary>
/// GroupMemberChatDataDomain Data Structure.
/// </summary>
[Serializable]

public class GroupMemberChatDataDomain : TopObject
{
	        /// <summary>
	        /// 聊天记录数
	        /// </summary>
	        [XmlElement("chat_cnt")]
	        public string ChatCnt { get; set; }
	
	        /// <summary>
	        /// 客户类型
	        /// </summary>
	        [XmlElement("custom_flag")]
	        public string CustomFlag { get; set; }
	
	        /// <summary>
	        /// 发送者staffid
	        /// </summary>
	        [XmlElement("sender_staffid")]
	        public string SenderStaffid { get; set; }
}

	/// <summary>
/// GroupChatDataResultDomain Data Structure.
/// </summary>
[Serializable]

public class GroupChatDataResultDomain : TopObject
{
	        /// <summary>
	        /// 是否来自缓存
	        /// </summary>
	        [XmlElement("from_cache")]
	        public bool FromCache { get; set; }
	
	        /// <summary>
	        /// 是否被限流
	        /// </summary>
	        [XmlElement("is_block")]
	        public bool IsBlock { get; set; }
	
	        /// <summary>
	        /// 活跃数据对象
	        /// </summary>
	        [XmlArray("rawset")]
	        [XmlArrayItem("group_member_chat_data")]
	        public List<GroupMemberChatDataDomain> Rawset { get; set; }
	
	        /// <summary>
	        /// 执行时间
	        /// </summary>
	        [XmlElement("runtime")]
	        public long Runtime { get; set; }
}

    }
}
