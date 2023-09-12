using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.material.article.publish
    /// </summary>
    public class OapiMaterialArticlePublishRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMaterialArticlePublishResponse>
    {
        /// <summary>
        /// 文章id
        /// </summary>
        public Nullable<long> ArticleId { get; set; }

        /// <summary>
        /// 服务号的unionid
        /// </summary>
        public string Unionid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.material.article.publish";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("article_id", this.ArticleId);
            parameters.Add("unionid", this.Unionid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("article_id", this.ArticleId);
            RequestValidator.ValidateRequired("unionid", this.Unionid);
        }

        #endregion
    }
}
