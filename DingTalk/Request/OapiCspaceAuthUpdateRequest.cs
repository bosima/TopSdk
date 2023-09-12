using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.cspace.auth.update
    /// </summary>
    public class OapiCspaceAuthUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCspaceAuthUpdateResponse>
    {
        /// <summary>
        /// 微应用的agentId
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 授权码有效期，单位为日，为空则表示永久授权
        /// </summary>
        public Nullable<long> Duration { get; set; }

        /// <summary>
        /// isv授权码
        /// </summary>
        public string IsvCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.cspace.auth.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("duration", this.Duration);
            parameters.Add("isv_code", this.IsvCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("isv_code", this.IsvCode);
        }

        #endregion
    }
}
