using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.appstore.internal.order.consume
    /// </summary>
    public class OapiAppstoreInternalOrderConsumeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAppstoreInternalOrderConsumeResponse>
    {
        /// <summary>
        /// 内购商品订单号
        /// </summary>
        public Nullable<long> BizOrderId { get; set; }

        /// <summary>
        /// 订购商品核销数量
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        /// <summary>
        /// 核销请求Id，由ISV生成，用于请求幂等
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// 员工在当前企业内的唯一标识，也称staffId
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.appstore.internal.order.consume";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_order_id", this.BizOrderId);
            parameters.Add("quantity", this.Quantity);
            parameters.Add("request_id", this.RequestId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_order_id", this.BizOrderId);
            RequestValidator.ValidateRequired("quantity", this.Quantity);
            RequestValidator.ValidateRequired("request_id", this.RequestId);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
