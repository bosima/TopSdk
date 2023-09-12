using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.microapp.rule.get_rule_list
    /// </summary>
    public class OapiMicroappRuleGetRuleListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMicroappRuleGetRuleListResponse>
    {
        /// <summary>
        /// 微应用在企业内的id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 用户在企业内的唯一标识
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.microapp.rule.get_rule_list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentId", this.AgentId);
            parameters.Add("userid", this.Userid);
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
