using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingpay.order.applypay
    /// </summary>
    public class OapiDingpayOrderApplypayRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingpayOrderApplypayResponse>
    {
        /// <summary>
        /// 发起支付操作员userId
        /// </summary>
        public string ApplyPayOperatorUserid { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNos { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        public string PayChannel { get; set; }

        /// <summary>
        /// 支付渠道方付款者真实出资UID
        /// </summary>
        public string PayChannelPayerRealUid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingpay.order.applypay";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("apply_pay_operator_userid", this.ApplyPayOperatorUserid);
            parameters.Add("extension", this.Extension);
            parameters.Add("order_nos", this.OrderNos);
            parameters.Add("pay_channel", this.PayChannel);
            parameters.Add("pay_channel_payer_real_uid", this.PayChannelPayerRealUid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("apply_pay_operator_userid", this.ApplyPayOperatorUserid);
            RequestValidator.ValidateRequired("order_nos", this.OrderNos);
            RequestValidator.ValidateMaxListSize("order_nos", this.OrderNos, 20);
            RequestValidator.ValidateRequired("pay_channel", this.PayChannel);
        }

        #endregion
    }
}
