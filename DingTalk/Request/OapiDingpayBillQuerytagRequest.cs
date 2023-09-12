using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingpay.bill.querytag
    /// </summary>
    public class OapiDingpayBillQuerytagRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingpayBillQuerytagResponse>
    {
        /// <summary>
        /// 业务代码
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 查询最近几天的标签
        /// </summary>
        public Nullable<long> DayRange { get; set; }

        /// <summary>
        /// 标签来源应用ID
        /// </summary>
        public string SourceAppId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingpay.bill.querytag";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("day_range", this.DayRange);
            parameters.Add("source_app_id", this.SourceAppId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("day_range", this.DayRange);
            RequestValidator.ValidateRequired("source_app_id", this.SourceAppId);
        }

        #endregion
    }
}
