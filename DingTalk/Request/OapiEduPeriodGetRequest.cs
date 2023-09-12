using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.period.get
    /// </summary>
    public class OapiEduPeriodGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduPeriodGetResponse>
    {
        /// <summary>
        /// 学段ID
        /// </summary>
        public Nullable<long> PeriodId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.period.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("period_id", this.PeriodId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("period_id", this.PeriodId);
        }

        #endregion
    }
}
