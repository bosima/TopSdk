using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.appstore.orders.special_canal.update_order
    /// </summary>
    public class OapiAppstoreOrdersSpecialCanalUpdateOrderRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAppstoreOrdersSpecialCanalUpdateOrderResponse>
    {
        /// <summary>
        /// 钉钉订单id
        /// </summary>
        public string DingOrderId { get; set; }

        /// <summary>
        /// 状态。已支付是3，已完成是4，已取消是1
        /// </summary>
        public Nullable<long> Status { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.appstore.orders.special_canal.update_order";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ding_order_id", this.DingOrderId);
            parameters.Add("status", this.Status);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ding_order_id", this.DingOrderId);
            RequestValidator.ValidateRequired("status", this.Status);
        }

        #endregion
    }
}
