using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.microapp.rule.get_user_total
    /// </summary>
    public class OapiMicroappRuleGetUserTotalRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMicroappRuleGetUserTotalResponse>
    {
        /// <summary>
        /// 规则所属的微应用agentId
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 需要查询的规则id集合
        /// </summary>
        public List<long> RuleIdList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.microapp.rule.get_user_total";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentId", this.AgentId);
            parameters.Add("ruleIdList", TopUtils.ObjectToJson(this.RuleIdList));
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
