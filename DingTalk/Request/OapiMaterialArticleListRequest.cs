using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.material.article.list
    /// </summary>
    public class OapiMaterialArticleListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMaterialArticleListResponse>
    {
        /// <summary>
        /// 每页条数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public Nullable<long> PageStart { get; set; }

        /// <summary>
        /// 服务号的unionid
        /// </summary>
        public string Unionid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.material.article.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("page_size", this.PageSize);
            parameters.Add("page_start", this.PageStart);
            parameters.Add("unionid", this.Unionid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 20);
            RequestValidator.ValidateRequired("page_start", this.PageStart);
            RequestValidator.ValidateRequired("unionid", this.Unionid);
        }

        #endregion
    }
}
