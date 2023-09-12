using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.report.comment.list
    /// </summary>
    public class OapiReportCommentListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiReportCommentListResponse>
    {
        /// <summary>
        /// 分页查询的游标，最开始传0，后续传返回参数中的next_cursor值，默认值为0
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 日志id
        /// </summary>
        public string ReportId { get; set; }

        /// <summary>
        /// 分页参数，每页大小，最多传20，默认值为20
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.report.comment.list";
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
