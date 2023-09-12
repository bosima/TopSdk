using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.customerservice.member.get
    /// </summary>
    public class OapiCustomerserviceMemberGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCustomerserviceMemberGetResponse>
    {
        /// <summary>
        /// 钉钉企业id
        /// </summary>
        public string DingCorpId { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        public string OpenInstanceId { get; set; }

        /// <summary>
        /// 1，智能客服
        /// </summary>
        public Nullable<long> ProductionType { get; set; }

        /// <summary>
        /// 三方租户id
        /// </summary>
        public string ThirdTenantId { get; set; }

        /// <summary>
        /// 账号id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 账号来源
        /// </summary>
        public string UserSourceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.customerservice.member.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ding_corp_id", this.DingCorpId);
            parameters.Add("open_instance_id", this.OpenInstanceId);
            parameters.Add("production_type", this.ProductionType);
            parameters.Add("third_tenant_id", this.ThirdTenantId);
            parameters.Add("user_id", this.UserId);
            parameters.Add("user_source_id", this.UserSourceId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("third_tenant_id", this.ThirdTenantId);
            RequestValidator.ValidateRequired("user_id", this.UserId);
            RequestValidator.ValidateRequired("user_source_id", this.UserSourceId);
        }

        #endregion
    }
}
