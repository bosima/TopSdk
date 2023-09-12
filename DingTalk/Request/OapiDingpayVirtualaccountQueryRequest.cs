using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingpay.virtualaccount.query
    /// </summary>
    public class OapiDingpayVirtualaccountQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingpayVirtualaccountQueryResponse>
    {
        /// <summary>
        /// 扩展属性
        /// </summary>
        public string Extension { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingpay.virtualaccount.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("extension", this.Extension);
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
