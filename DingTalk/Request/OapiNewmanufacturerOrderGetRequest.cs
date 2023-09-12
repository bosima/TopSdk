using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.newmanufacturer.order.get
    /// </summary>
    public class OapiNewmanufacturerOrderGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiNewmanufacturerOrderGetResponse>
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        public string TenantId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.newmanufacturer.order.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("number", this.Number);
            parameters.Add("tenant_id", this.TenantId);
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
