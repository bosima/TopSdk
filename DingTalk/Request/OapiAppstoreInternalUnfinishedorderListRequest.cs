using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.appstore.internal.unfinishedorder.list
    /// </summary>
    public class OapiAppstoreInternalUnfinishedorderListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAppstoreInternalUnfinishedorderListResponse>
    {
        /// <summary>
        /// 商品规格码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 分页查询页码，其实页码为1
        /// </summary>
        public Nullable<long> Page { get; set; }

        /// <summary>
        /// 分页查询每页大小，最大限制100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.appstore.internal.unfinishedorder.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_code", this.ItemCode);
            parameters.Add("page", this.Page);
            parameters.Add("page_size", this.PageSize);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

        #endregion
    }
}
