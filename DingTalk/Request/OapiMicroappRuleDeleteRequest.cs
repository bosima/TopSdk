using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.microapp.rule.delete
    /// </summary>
    public class OapiMicroappRuleDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMicroappRuleDeleteResponse>
    {
        /// <summary>
        /// 规则所属的微应用agentId
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 被删除的规则id
        /// </summary>
        public Nullable<long> RuleId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.microapp.rule.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentId", this.AgentId);
            parameters.Add("ruleId", this.RuleId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
