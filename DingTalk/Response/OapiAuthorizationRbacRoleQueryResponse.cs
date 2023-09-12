using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAuthorizationRbacRoleQueryResponse.
    /// </summary>
    public class OapiAuthorizationRbacRoleQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 响应结果
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// OpenContactScopeVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenContactScopeVoDomain : TopObject
{
	        /// <summary>
	        /// 被授权人可管理的部门列表
	        /// </summary>
	        [XmlArray("dept_ids")]
	        [XmlArrayItem("number")]
	        public List<long> DeptIds { get; set; }
	
	        /// <summary>
	        /// 被授权人所在部门
	        /// </summary>
	        [XmlElement("include_member_depts")]
	        public bool IncludeMemberDepts { get; set; }
	
	        /// <summary>
	        /// 被授权人所能管理的部门
	        /// </summary>
	        [XmlElement("include_self_manage_depts")]
	        public bool IncludeSelfManageDepts { get; set; }
	
	        /// <summary>
	        /// 被授权人可管理的员工列表
	        /// </summary>
	        [XmlArray("userids")]
	        [XmlArrayItem("string")]
	        public List<string> Userids { get; set; }
}

	/// <summary>
/// OpenConditionVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenConditionVoDomain : TopObject
{
	        /// <summary>
	        /// 通讯录约束条件
	        /// </summary>
	        [XmlElement("open_contact_scope")]
	        public OpenContactScopeVoDomain OpenContactScope { get; set; }
}

	/// <summary>
/// OpenActionVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenActionVoDomain : TopObject
{
	        /// <summary>
	        /// actionIds
	        /// </summary>
	        [XmlArray("action_ids")]
	        [XmlArrayItem("string")]
	        public List<string> ActionIds { get; set; }
	
	        /// <summary>
	        /// 约束条件
	        /// </summary>
	        [XmlElement("open_conditon")]
	        public OpenConditionVoDomain OpenConditon { get; set; }
}

	/// <summary>
/// OpenMemberVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenMemberVoDomain : TopObject
{
	        /// <summary>
	        /// member所属组织corpid
	        /// </summary>
	        [XmlElement("belong_corpid")]
	        public string BelongCorpid { get; set; }
	
	        /// <summary>
	        /// member id
	        /// </summary>
	        [XmlElement("member_id")]
	        public string MemberId { get; set; }
	
	        /// <summary>
	        /// member类型
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
/// OpenEamRoleVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEamRoleVoDomain : TopObject
{
	        /// <summary>
	        /// openAction
	        /// </summary>
	        [XmlElement("open_action")]
	        public OpenActionVoDomain OpenAction { get; set; }
	
	        /// <summary>
	        /// openMemberVO
	        /// </summary>
	        [XmlArray("open_members")]
	        [XmlArrayItem("open_member_vo")]
	        public List<OpenMemberVoDomain> OpenMembers { get; set; }
	
	        /// <summary>
	        /// 管理组授权的资源
	        /// </summary>
	        [XmlArray("open_resources")]
	        [XmlArrayItem("string")]
	        public List<string> OpenResources { get; set; }
	
	        /// <summary>
	        /// 管理组id
	        /// </summary>
	        [XmlElement("open_role_id")]
	        public string OpenRoleId { get; set; }
	
	        /// <summary>
	        /// 管理组名称
	        /// </summary>
	        [XmlElement("open_role_name")]
	        public string OpenRoleName { get; set; }
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
	        /// 响应结果
	        /// </summary>
	        [XmlArray("result")]
	        [XmlArrayItem("open_eam_role_vo")]
	        public List<OpenEamRoleVoDomain> Result { get; set; }
	
	        /// <summary>
	        /// 调用是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
