using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.material.article.add
    /// </summary>
    public class OapiMaterialArticleAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMaterialArticleAddResponse>
    {
        /// <summary>
        /// 文章参数对象
        /// </summary>
        public string Article { get; set; }

        public ArticleCreateDTODomain Article_ { set { this.Article = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 服务号的unionid
        /// </summary>
        public string Unionid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.material.article.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("article", this.Article);
            parameters.Add("unionid", this.Unionid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("article", this.Article);
            RequestValidator.ValidateRequired("unionid", this.Unionid);
        }

	/// <summary>
/// ArticleCreateDTODomain Data Structure.
/// </summary>
[Serializable]

public class ArticleCreateDTODomain : TopObject
{
	        /// <summary>
	        /// 文章内容（html码）
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 摘要
	        /// </summary>
	        [XmlElement("digest")]
	        public string Digest { get; set; }
	
	        /// <summary>
	        /// 图文消息的封面图片素材id
	        /// </summary>
	        [XmlElement("thumb_media_id")]
	        public string ThumbMediaId { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 幂等参数
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

        #endregion
    }
}
