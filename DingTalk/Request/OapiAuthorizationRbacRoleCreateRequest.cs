using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.authorization.rbac.role.create
    /// </summary>
    public class OapiAuthorizationRbacRoleCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAuthorizationRbacRoleCreateResponse>
    {
        /// <summary>
        /// 微应用agenId,需要联系权限平台配置
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 管理组详情
        /// </summary>
        public string OpenRoleCreate { get; set; }

        public OpenRoleCreateVoDomain OpenRoleCreate_ { set { this.OpenRoleCreate = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.authorization.rbac.role.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("open_role_create", this.OpenRoleCreate);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("open_role_create", this.OpenRoleCreate);
        }

	/// <summary>
/// OpenContactScopeVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenContactScopeVoDomain : TopObject
{
	        /// <summary>
	        /// 可管理的指定部门
	        /// </summary>
	        [XmlArray("dept_ids")]
	        [XmlArrayItem("number")]
	        public List<string> DeptIds { get; set; }
	
	        /// <summary>
	        /// 员工所在的部门
	        /// </summary>
	        [XmlElement("include_member_depts")]
	        public Nullable<bool> IncludeMemberDepts { get; set; }
	
	        /// <summary>
	        /// 主管能管理的部门
	        /// </summary>
	        [XmlElement("include_self_manage_depts")]
	        public Nullable<bool> IncludeSelfManageDepts { get; set; }
	
	        /// <summary>
	        /// 可管理的员工列表
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
	        /// contactScope
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
	        /// acitonId列表
	        /// </summary>
	        [XmlArray("action_ids")]
	        [XmlArrayItem("string")]
	        public List<string> ActionIds { get; set; }
	
	        /// <summary>
	        /// conditon
	        /// </summary>
	        [XmlElement("open_condition")]
	        public OpenConditionVoDomain OpenCondition { get; set; }
}

	/// <summary>
/// OpenMemberVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenMemberVoDomain : TopObject
{
	        /// <summary>
	        /// member所属组织
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
/// OpenRoleCreateVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenRoleCreateVoDomain : TopObject
{
	        /// <summary>
	        /// aciton列表
	        /// </summary>
	        [XmlElement("open_action")]
	        public OpenActionVoDomain OpenAction { get; set; }
	
	        /// <summary>
	        /// 成员列表
	        /// </summary>
	        [XmlArray("open_members")]
	        [XmlArrayItem("open_member_vo")]
	        public List<OpenMemberVoDomain> OpenMembers { get; set; }
	
	        /// <summary>
	        /// 资源列表
	        /// </summary>
	        [XmlArray("open_resources")]
	        [XmlArrayItem("string")]
	        public List<string> OpenResources { get; set; }
	
	        /// <summary>
	        /// 管理组id,注意:创建的时候不要填写
	        /// </summary>
	        [XmlElement("open_role_id")]
	        public string OpenRoleId { get; set; }
	
	        /// <summary>
	        /// 管理组名
	        /// </summary>
	        [XmlElement("open_role_name")]
	        public string OpenRoleName { get; set; }
}

        #endregion
    }
}
