using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAuthorizationRbacPermissionGetResponse.
    /// </summary>
    public class OapiAuthorizationRbacPermissionGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 服务端响应
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
	        /// 部门id列表
	        /// </summary>
	        [XmlArray("dept_ids")]
	        [XmlArrayItem("number")]
	        public List<long> DeptIds { get; set; }
	
	        /// <summary>
	        /// 被授权人所在的部门
	        /// </summary>
	        [XmlElement("include_member_depts")]
	        public bool IncludeMemberDepts { get; set; }
	
	        /// <summary>
	        /// 被授权人所管理的部门
	        /// </summary>
	        [XmlElement("include_self_manage_depts")]
	        public bool IncludeSelfManageDepts { get; set; }
	
	        /// <summary>
	        /// 员工列表
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
	        /// 通讯录范围约束
	        /// </summary>
	        [XmlElement("open_contact_scope")]
	        public OpenContactScopeVoDomain OpenContactScope { get; set; }
}

	/// <summary>
/// OpenActionResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenActionResultVoDomain : TopObject
{
	        /// <summary>
	        /// actionId
	        /// </summary>
	        [XmlElement("action_id")]
	        public string ActionId { get; set; }
	
	        /// <summary>
	        /// 权限的范围约束
	        /// </summary>
	        [XmlElement("open_condition")]
	        public OpenConditionVoDomain OpenCondition { get; set; }
}

	/// <summary>
/// PermitResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class PermitResultVoDomain : TopObject
{
	        /// <summary>
	        /// action列表
	        /// </summary>
	        [XmlArray("open_action_results")]
	        [XmlArrayItem("open_action_result_vo")]
	        public List<OpenActionResultVoDomain> OpenActionResults { get; set; }
	
	        /// <summary>
	        /// 是否有权限
	        /// </summary>
	        [XmlElement("permit")]
	        public bool Permit { get; set; }
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
	        /// PermitResultVo
	        /// </summary>
	        [XmlElement("result")]
	        public PermitResultVoDomain Result { get; set; }
	
	        /// <summary>
	        /// 鉴权成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
