using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.authorization.rbac.role.name.update
    /// </summary>
    public class OapiAuthorizationRbacRoleNameUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAuthorizationRbacRoleNameUpdateResponse>
    {
        /// <summary>
        /// 微应用agenId,需要联系权限平台配置
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 管理组id
        /// </summary>
        public string OpenRoleId { get; set; }

        /// <summary>
        /// 管理组名称
        /// </summary>
        public string RoleName { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.authorization.rbac.role.name.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("open_role_id", this.OpenRoleId);
            parameters.Add("role_name", this.RoleName);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("open_role_id", this.OpenRoleId);
            RequestValidator.ValidateRequired("role_name", this.RoleName);
        }

        #endregion
    }
}
