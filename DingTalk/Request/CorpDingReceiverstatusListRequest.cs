using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.ding.receiverstatus.list
    /// </summary>
    public class CorpDingReceiverstatusListRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpDingReceiverstatusListResponse>
    {
        /// <summary>
        /// 确认状态，三种情况：不传表示查所有；传0表示查未确认状态；传1表示查已经确认状态；
        /// </summary>
        public Nullable<long> ConfirmedStatus { get; set; }

        /// <summary>
        /// dingid
        /// </summary>
        public string DingId { get; set; }

        /// <summary>
        /// 分页页码，从1开始
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页显示数量，最大值50
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.ding.receiverstatus.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("confirmed_status", this.ConfirmedStatus);
            parameters.Add("ding_id", this.DingId);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ding_id", this.DingId);
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 50);
        }

        #endregion
    }
}
