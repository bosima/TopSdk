using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.cspace.auditlog.list
    /// </summary>
    public class OapiCspaceAuditlogListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCspaceAuditlogListResponse>
    {
        /// <summary>
        /// 操作日志截止时间，unix时间戳，单位ms
        /// </summary>
        public Nullable<long> EndDate { get; set; }

        /// <summary>
        /// 操作记录文件id，作为分页偏移量，与load_more_gmt_create一起使用，返回记录的biz_id为load_more_biz_id且gmt_create为load_more_gmt_create之后的操作列表，分页查询获取下一页时，传最后一条记录的biz_id和gmt_create。
        /// </summary>
        public Nullable<long> LoadMoreBizId { get; set; }

        /// <summary>
        /// 操作记录生成时间，作为分页偏移量，分页查询时必传，unix时间戳，单位ms
        /// </summary>
        public Nullable<long> LoadMoreGmtCreate { get; set; }

        /// <summary>
        /// 操作列表长度，最大500
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 操作日志起始时间，unix时间戳，单位ms
        /// </summary>
        public Nullable<long> StartDate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.cspace.auditlog.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_date", this.EndDate);
            parameters.Add("load_more_biz_id", this.LoadMoreBizId);
            parameters.Add("load_more_gmt_create", this.LoadMoreGmtCreate);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_date", this.StartDate);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("start_date", this.StartDate);
        }

        #endregion
    }
}
