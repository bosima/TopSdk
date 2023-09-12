using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.material.news.update
    /// </summary>
    public class OapiMaterialNewsUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMaterialNewsUpdateResponse>
    {
        /// <summary>
        /// 文章列表
        /// </summary>
        public string Articles { get; set; }

        public List<ArticleDTODomain> Articles_ { set { this.Articles = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 消息卡片素材id
        /// </summary>
        public string MediaId { get; set; }

        /// <summary>
        /// 服务号的unionid
        /// </summary>
        public string Unionid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.material.news.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("articles", this.Articles);
            parameters.Add("media_id", this.MediaId);
            parameters.Add("unionid", this.Unionid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("articles", this.Articles, 8);
            RequestValidator.ValidateRequired("media_id", this.MediaId);
            RequestValidator.ValidateRequired("unionid", this.Unionid);
        }

	/// <summary>
/// ArticleDTODomain Data Structure.
/// </summary>
[Serializable]

public class ArticleDTODomain : TopObject
{
	        /// <summary>
	        /// 文章id
	        /// </summary>
	        [XmlElement("article_id")]
	        public Nullable<long> ArticleId { get; set; }
}

        #endregion
    }
}
