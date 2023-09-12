using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAuthorizationRbacRoleMemberListResponse.
    /// </summary>
    public class OapiAuthorizationRbacRoleMemberListResponse : DingTalkResponse
    {
        /// <summary>
        /// DingOpenResult
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// OpenMemberVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenMemberVoDomain : TopObject
{
	        /// <summary>
	        /// 成员所属corpid
	        /// </summary>
	        [XmlElement("belong_corpid")]
	        public string BelongCorpid { get; set; }
	
	        /// <summary>
	        /// 成员id
	        /// </summary>
	        [XmlElement("member_id")]
	        public string MemberId { get; set; }
	
	        /// <summary>
	        /// 成员类型
	        /// </summary>
	        [XmlElement("member_type")]
	        public string MemberType { get; set; }
	
	        /// <summary>
	        /// 操作人userid
	        /// </summary>
	        [XmlElement("operate_userid")]
	        public string OperateUserid { get; set; }
}

	/// <summary>
/// PageVoDomain Data Structure.
/// </summary>
[Serializable]

public class PageVoDomain : TopObject
{
	        /// <summary>
	        /// hasMore
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 成员列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("open_member_vo")]
	        public List<OpenMemberVoDomain> List { get; set; }
	
	        /// <summary>
	        /// nexCursor
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
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
	        /// PageVo
	        /// </summary>
	        [XmlElement("result")]
	        public PageVoDomain Result { get; set; }
	
	        /// <summary>
	        /// 调用是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
