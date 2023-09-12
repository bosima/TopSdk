using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.cspace.auth.cancel
    /// </summary>
    public class OapiCspaceAuthCancelRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCspaceAuthCancelResponse>
    {
        /// <summary>
        /// 微应用的agentId
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// isv文件授权码
        /// </summary>
        public string IsvCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.cspace.auth.cancel";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
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
