using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.report.statistics
    /// </summary>
    public class OapiReportStatisticsRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiReportStatisticsResponse>
    {
        /// <summary>
        /// 日志id
        /// </summary>
        public string ReportId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.report.statistics";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("report_id", this.ReportId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("report_id", this.ReportId);
        }

        #endregion
    }
}
