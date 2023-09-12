using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.serviceaccount.list
    /// </summary>
    public class OapiServiceaccountListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiServiceaccountListResponse>
    {
        /// <summary>
        /// 每页条数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 页码，第几页，从1开始算
        /// </summary>
        public Nullable<long> PageStart { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.serviceaccount.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("pageSize", this.PageSize);
            parameters.Add("pageStart", this.PageStart);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxValue("pageSize", this.PageSize, 50);
            RequestValidator.ValidateMinValue("pageSize", this.PageSize, 1);
            RequestValidator.ValidateMinValue("pageStart", this.PageStart, 1);
        }

        #endregion
    }
}
