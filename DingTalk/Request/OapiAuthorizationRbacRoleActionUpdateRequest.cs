using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.authorization.rbac.role.action.update
    /// </summary>
    public class OapiAuthorizationRbacRoleActionUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAuthorizationRbacRoleActionUpdateResponse>
    {
        /// <summary>
        /// 微应用agenId,需要联系权限平台配置
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// action
        /// </summary>
        public string OpenAction { get; set; }

        public OpenActionVoDomain OpenAction_ { set { this.OpenAction = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 管理组id
        /// </summary>
        public string OpenRoleId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.authorization.rbac.role.action.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("open_action", this.OpenAction);
            parameters.Add("open_role_id", this.OpenRoleId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("open_action", this.OpenAction);
            RequestValidator.ValidateRequired("open_role_id", this.OpenRoleId);
        }

	/// <summary>
/// OpenContactScopeVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenContactScopeVoDomain : TopObject
{
	        /// <summary>
	        /// 可管理的部门id列表
	        /// </summary>
	        [XmlArray("dept_ids")]
	        [XmlArrayItem("number")]
	        public List<string> DeptIds { get; set; }
	
	        /// <summary>
	        /// 是否包含所在的部门
	        /// </summary>
	        [XmlElement("include_member_depts")]
	        public Nullable<bool> IncludeMemberDepts { get; set; }
	
	        /// <summary>
	        /// 是否包含可管理的部门
	        /// </summary>
	        [XmlElement("include_self_manage_depts")]
	        public Nullable<bool> IncludeSelfManageDepts { get; set; }
	
	        /// <summary>
	        /// 员工id列表
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
	        /// 通讯录约束范围
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
	        /// actionId列表
	        /// </summary>
	        [XmlArray("action_ids")]
	        [XmlArrayItem("string")]
	        public List<string> ActionIds { get; set; }
	
	        /// <summary>
	        /// condition
	        /// </summary>
	        [XmlElement("open_condition")]
	        public OpenConditionVoDomain OpenCondition { get; set; }
}

        #endregion
    }
}
