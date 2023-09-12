using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.flexible.applytoken
    /// </summary>
    public class OapiSmartworkHrmFlexibleApplytokenRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmFlexibleApplytokenResponse>
    {
        /// <summary>
        /// 微应用在企业的AgentId，不需要自定义字段可不传
        /// </summary>
        public Nullable<long> Agentid { get; set; }

        /// <summary>
        /// 用户在企业的ID
        /// </summary>
        public string OptUserId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.flexible.applytoken";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("opt_user_id", this.OptUserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agentid", this.Agentid);
            RequestValidator.ValidateRequired("opt_user_id", this.OptUserId);
        }

        #endregion
    }
}
