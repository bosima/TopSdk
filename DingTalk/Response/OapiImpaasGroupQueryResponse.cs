using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasGroupQueryResponse.
    /// </summary>
    public class OapiImpaasGroupQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 群信息
        /// </summary>
        [XmlElement("result")]
        public GroupInfoDomain Result { get; set; }

	/// <summary>
/// BaseGroupMemberInfoDomain Data Structure.
/// </summary>
[Serializable]

public class BaseGroupMemberInfoDomain : TopObject
{
	        /// <summary>
	        /// 群主ID，类型由type字段决定
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 账号ID类型，当type=staff时，id填写staffid，当type=channelUser时，id字段填写channelUserId
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// GroupInfoDomain Data Structure.
/// </summary>
[Serializable]

public class GroupInfoDomain : TopObject
{
	        /// <summary>
	        /// 群ID
	        /// </summary>
	        [XmlElement("chatid")]
	        public string Chatid { get; set; }
	
	        /// <summary>
	        /// 群主
	        /// </summary>
	        [XmlElement("creater")]
	        public BaseGroupMemberInfoDomain Creater { get; set; }
	
	        /// <summary>
	        /// 群名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
	
	        /// <summary>
	        /// 群成员人数
	        /// </summary>
	        [XmlElement("member_count")]
	        public long MemberCount { get; set; }
	
	        /// <summary>
	        /// 群成员人数上限
	        /// </summary>
	        [XmlElement("member_limit")]
	        public long MemberLimit { get; set; }
	
	        /// <summary>
	        /// 群类型
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
}

    }
}
