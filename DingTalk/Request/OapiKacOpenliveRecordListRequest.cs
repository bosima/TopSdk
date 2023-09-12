using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.kac.openlive.record.list
    /// </summary>
    public class OapiKacOpenliveRecordListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiKacOpenliveRecordListResponse>
    {
        /// <summary>
        /// 员工id
        /// </summary>
        public string AuthorUserId { get; set; }

        /// <summary>
        /// 查询时间范围开始时间戳
        /// </summary>
        public Nullable<long> BeginTime { get; set; }

        /// <summary>
        /// 查询时间范围结束时间戳
        /// </summary>
        public Nullable<long> EndTime { get; set; }

        /// <summary>
        /// 分页大小，小于等于100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 第几页，从1开始
        /// </summary>
        public Nullable<long> PageStart { get; set; }

        /// <summary>
        /// 直播状态：init: 未开播, living: 直播中，end: 直播已结束, null或空: 全体
        /// </summary>
        public string Status { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.kac.openlive.record.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("author_user_id", this.AuthorUserId);
            parameters.Add("begin_time", this.BeginTime);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("page_start", this.PageStart);
            parameters.Add("status", this.Status);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("author_user_id", this.AuthorUserId);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("page_start", this.PageStart);
        }

        #endregion
    }
}
