using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.report.statistics.listbytype
    /// </summary>
    public class OapiReportStatisticsListbytypeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiReportStatisticsListbytypeResponse>
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
        /// 分页参数，每页大小，最多传100，默认值为100
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 查询类型 0:已读人员列表 1:评论人员列表 2:点赞人员列表
        /// </summary>
        public Nullable<long> Type { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.report.statistics.listbytype";
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
            parameters.Add("type", this.Type);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("report_id", this.ReportId);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion
    }
}
