using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.appstore.internal.order.get
    /// </summary>
    public class OapiAppstoreInternalOrderGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAppstoreInternalOrderGetResponse>
    {
        /// <summary>
        /// 内购商品订单号
        /// </summary>
        public Nullable<long> BizOrderId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.appstore.internal.order.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_order_id", this.BizOrderId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_order_id", this.BizOrderId);
        }

        #endregion
    }
}
