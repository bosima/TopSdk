using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSnsConversationMemberListResponse.
    /// </summary>
    public class OapiSnsConversationMemberListResponse : DingTalkResponse
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
        /// 结果数据
        /// </summary>
        [XmlElement("result")]
        public SnsOpenGroupMemberResponseDomain Result { get; set; }

        /// <summary>
        /// 请求成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// SnsGroupMemberModelDomain Data Structure.
/// </summary>
[Serializable]

public class SnsGroupMemberModelDomain : TopObject
{
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
	        /// 头像url
	        /// </summary>
	        [XmlElement("portrait_url")]
	        public string PortraitUrl { get; set; }
	
	        /// <summary>
	        /// 角色，1-群主 2-管理员 3-普通成员
	        /// </summary>
	        [XmlElement("role")]
	        public long Role { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
}

	/// <summary>
/// SnsOpenGroupMemberResponseDomain Data Structure.
/// </summary>
[Serializable]

public class SnsOpenGroupMemberResponseDomain : TopObject
{
	        /// <summary>
	        /// 群成员是否还有下页数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 成员列表
	        /// </summary>
	        [XmlArray("members")]
	        [XmlArrayItem("sns_group_member_model")]
	        public List<SnsGroupMemberModelDomain> Members { get; set; }
	
	        /// <summary>
	        /// 下一页的游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public string NextCursor { get; set; }
}

    }
}
