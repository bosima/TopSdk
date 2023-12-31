using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.authorization.rbac.permission.get
    /// </summary>
    public class OapiAuthorizationRbacPermissionGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAuthorizationRbacPermissionGetResponse>
    {
        /// <summary>
        /// 微应用agenId,需要联系钉钉权限平台配置
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 需要鉴权资源xx.xx.xx
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.authorization.rbac.permission.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("resource", this.Resource);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("resource", this.Resource);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
