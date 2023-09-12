using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingpay.order.syncstatus
    /// </summary>
    public class OapiDingpayOrderSyncstatusRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingpayOrderSyncstatusResponse>
    {
        /// <summary>
        /// 钉支付订单号
        /// </summary>
        public string OrderNos { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingpay.order.syncstatus";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("order_nos", this.OrderNos);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_nos", this.OrderNos);
            RequestValidator.ValidateMaxListSize("order_nos", this.OrderNos, 20);
        }

        #endregion
    }
}
