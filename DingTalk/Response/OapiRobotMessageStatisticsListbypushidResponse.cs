using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRobotMessageStatisticsListbypushidResponse.
    /// </summary>
    public class OapiRobotMessageStatisticsListbypushidResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误值
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public RobotMsgStatPageResponseDomain Result { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// PaginationVoDomain Data Structure.
/// </summary>
[Serializable]

public class PaginationVoDomain : TopObject
{
	        /// <summary>
	        /// 当前页数
	        /// </summary>
	        [XmlElement("current_page")]
	        public long CurrentPage { get; set; }
	
	        /// <summary>
	        /// 总页数
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
	
	        /// <summary>
	        /// 总记录数
	        /// </summary>
	        [XmlElement("total_record_num")]
	        public long TotalRecordNum { get; set; }
}

	/// <summary>
/// MsgStatByPushIdResVoDomain Data Structure.
/// </summary>
[Serializable]

public class MsgStatByPushIdResVoDomain : TopObject
{
	        /// <summary>
	        /// 群Id
	        /// </summary>
	        [XmlElement("conversation_id")]
	        public string ConversationId { get; set; }
	
	        /// <summary>
	        /// 群成员数量
	        /// </summary>
	        [XmlElement("group_member_count")]
	        public long GroupMemberCount { get; set; }
	
	        /// <summary>
	        /// 群成员未读数量
	        /// </summary>
	        [XmlElement("group_member_unread_count")]
	        public long GroupMemberUnreadCount { get; set; }
	
	        /// <summary>
	        /// 机器人消息推送Id
	        /// </summary>
	        [XmlElement("push_id")]
	        public string PushId { get; set; }
}

	/// <summary>
/// RobotMsgStatPageResponseDomain Data Structure.
/// </summary>
[Serializable]

public class RobotMsgStatPageResponseDomain : TopObject
{
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("msg_stat_by_push_id_res_vo")]
	        public List<MsgStatByPushIdResVoDomain> List { get; set; }
	
	        /// <summary>
	        /// pagination
	        /// </summary>
	        [XmlElement("pagination")]
	        public PaginationVoDomain Pagination { get; set; }
}

    }
}
