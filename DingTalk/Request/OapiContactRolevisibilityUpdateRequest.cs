using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.contact.rolevisibility.update
    /// </summary>
    public class OapiContactRolevisibilityUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiContactRolevisibilityUpdateResponse>
    {
        /// <summary>
        /// 权限设置列表
        /// </summary>
        public string Permissions { get; set; }

        public List<OpenRolePermissionForContactDomain> Permissions_ { set { this.Permissions = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 角色id
        /// </summary>
        public Nullable<long> RoleId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.contact.rolevisibility.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("permissions", this.Permissions);
            parameters.Add("role_id", this.RoleId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("permissions", this.Permissions);
            RequestValidator.ValidateObjectMaxListSize("permissions", this.Permissions, 999);
            RequestValidator.ValidateRequired("role_id", this.RoleId);
        }

	/// <summary>
/// OpenRolePermissionForContactDomain Data Structure.
/// </summary>
[Serializable]

public class OpenRolePermissionForContactDomain : TopObject
{
	        /// <summary>
	        /// 部门id列表
	        /// </summary>
	        [XmlArray("dept_ids")]
	        [XmlArrayItem("number")]
	        public List<string> DeptIds { get; set; }
	
	        /// <summary>
	        /// 角色id列表
	        /// </summary>
	        [XmlArray("role_ids")]
	        [XmlArrayItem("number")]
	        public List<string> RoleIds { get; set; }
	
	        /// <summary>
	        /// subject规则(1)还是object规则(2)
	        /// </summary>
	        [XmlElement("side")]
	        public Nullable<long> Side { get; set; }
	
	        /// <summary>
	        /// permit(1) 还是 deny(2)
	        /// </summary>
	        [XmlElement("type")]
	        public Nullable<long> Type { get; set; }
	
	        /// <summary>
	        /// staffid列表
	        /// </summary>
	        [XmlArray("user_ids")]
	        [XmlArrayItem("number")]
	        public List<string> UserIds { get; set; }
	
	        /// <summary>
	        /// 可见性类型： 5. permit_self_node_and_children(仅可见自己所在节点及子节点)     6. permit_self_node_only(仅可见自己所在的节点)    7. permit_self_only(仅可见自己)
	        /// </summary>
	        [XmlElement("visibility_type")]
	        public Nullable<long> VisibilityType { get; set; }
}

        #endregion
    }
}
