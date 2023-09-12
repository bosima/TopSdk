using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingpay.order.terminate
    /// </summary>
    public class OapiDingpayOrderTerminateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingpayOrderTerminateResponse>
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// 操作者员工号
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// dingpay单号列表
        /// </summary>
        public string OrderNos { get; set; }

        /// <summary>
        /// 中止原因
        /// </summary>
        public string Reason { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingpay.order.terminate";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("extension", this.Extension);
            parameters.Add("operator", this.Operator);
            parameters.Add("order_nos", this.OrderNos);
            parameters.Add("reason", this.Reason);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("operator", this.Operator);
            RequestValidator.ValidateRequired("order_nos", this.OrderNos);
            RequestValidator.ValidateMaxListSize("order_nos", this.OrderNos, 20);
            RequestValidator.ValidateRequired("reason", this.Reason);
        }

        #endregion
    }
}
