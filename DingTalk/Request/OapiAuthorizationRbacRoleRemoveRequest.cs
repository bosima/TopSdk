using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.authorization.rbac.role.remove
    /// </summary>
    public class OapiAuthorizationRbacRoleRemoveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAuthorizationRbacRoleRemoveResponse>
    {
        /// <summary>
        /// 微应用agenId,需要联系权限平台配置
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 管理组id
        /// </summary>
        public string OpenRoleId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.authorization.rbac.role.remove";
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
        }

        #endregion
    }
}
