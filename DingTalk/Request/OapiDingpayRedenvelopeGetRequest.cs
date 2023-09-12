using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingpay.redenvelope.get
    /// </summary>
    public class OapiDingpayRedenvelopeGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingpayRedenvelopeGetResponse>
    {
        /// <summary>
        /// 企业订单号
        /// </summary>
        public string CorpBizNo { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingpay.redenvelope.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("corp_biz_no", this.CorpBizNo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("corp_biz_no", this.CorpBizNo);
        }

        #endregion
    }
}
