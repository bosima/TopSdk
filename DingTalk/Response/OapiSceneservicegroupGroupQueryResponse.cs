using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSceneservicegroupGroupQueryResponse.
    /// </summary>
    public class OapiSceneservicegroupGroupQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 分页对象
        /// </summary>
        [XmlElement("result")]
        public PageDomain Result { get; set; }

	/// <summary>
/// GroupResponseDomain Data Structure.
/// </summary>
[Serializable]

public class GroupResponseDomain : TopObject
{
	        /// <summary>
	        /// 群名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
	
	        /// <summary>
	        /// 开放群id
	        /// </summary>
	        [XmlElement("open_conversationid")]
	        public string OpenConversationid { get; set; }
	
	        /// <summary>
	        /// 开放群组id
	        /// </summary>
	        [XmlElement("open_groupsetid")]
	        public string OpenGroupsetid { get; set; }
	
	        /// <summary>
	        /// 开放团队ID
	        /// </summary>
	        [XmlElement("open_teamid")]
	        public string OpenTeamid { get; set; }
}

	/// <summary>
/// PageDomain Data Structure.
/// </summary>
[Serializable]

public class PageDomain : TopObject
{
	        /// <summary>
	        /// 表示是否还有更多的数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 表示下一次分页的游标，如果next_corsor为null或者has_more为false，表示没有更多的分页数据
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
	
	        /// <summary>
	        /// 返回对象
	        /// </summary>
	        [XmlArray("records")]
	        [XmlArrayItem("group_response")]
	        public List<GroupResponseDomain> Records { get; set; }
	
	        /// <summary>
	        /// 总记录数
	        /// </summary>
	        [XmlElement("total_count")]
	        public long TotalCount { get; set; }
}

    }
}
