using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.report.receiver.list
    /// </summary>
    public class OapiReportReceiverListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiReportReceiverListResponse>
    {
        /// <summary>
        /// 分页查询的游标，最开始传0，后续传返回参数中next_cursor的值，默认值为0
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 日志id
        /// </summary>
        public string ReportId { get; set; }

        /// <summary>
        /// 分页参数，每页大小，最多传100，默认值为100
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.report.receiver.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("offset", this.Offset);
            parameters.Add("report_id", this.ReportId);
            parameters.Add("size", this.Size);
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
