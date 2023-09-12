using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatServicegroupMemberQueryResponse.
    /// </summary>
    public class OapiImChatServicegroupMemberQueryResponse : DingTalkResponse
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
        public ServiceGroupMemberQueryResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// MembersDomain Data Structure.
/// </summary>
[Serializable]

public class MembersDomain : TopObject
{
	        /// <summary>
	        /// 成员的ID
	        /// </summary>
	        [XmlElement("dingtalk_id")]
	        public string DingtalkId { get; set; }
	
	        /// <summary>
	        /// 群昵称
	        /// </summary>
	        [XmlElement("group_nick_name")]
	        public string GroupNickName { get; set; }
	
	        /// <summary>
	        /// 昵称
	        /// </summary>
	        [XmlElement("nick_name")]
	        public string NickName { get; set; }
	
	        /// <summary>
	        /// 角色，2-管理员、3-普通成员
	        /// </summary>
	        [XmlElement("role")]
	        public string Role { get; set; }
	
	        /// <summary>
	        /// 员工Id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// ServiceGroupMemberQueryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ServiceGroupMemberQueryResponseDomain : TopObject
{
	        /// <summary>
	        /// 成员列表
	        /// </summary>
	        [XmlArray("members")]
	        [XmlArrayItem("members")]
	        public List<MembersDomain> Members { get; set; }
	
	        /// <summary>
	        /// 成员总数
	        /// </summary>
	        [XmlElement("total_count")]
	        public long TotalCount { get; set; }
}

    }
}
