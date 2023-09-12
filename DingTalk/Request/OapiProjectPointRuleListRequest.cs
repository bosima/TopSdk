using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.project.point.rule.list
    /// </summary>
    public class OapiProjectPointRuleListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProjectPointRuleListResponse>
    {
        /// <summary>
        /// 业务ID（固定值，农村积分传7001）
        /// </summary>
        public Nullable<long> TenantId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.project.point.rule.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("tenant_id", this.TenantId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

        #endregion
    }
}
