using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMaterialNewsListResponse.
    /// </summary>
    public class OapiMaterialNewsListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 当前返回记录数
        /// </summary>
        [XmlElement("item_count")]
        public long ItemCount { get; set; }

        /// <summary>
        /// 卡片列表
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("news_card_d_t_o")]
        public List<NewsCardDTODomain> Items { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

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
	        public long ArticleId { get; set; }
	
	        /// <summary>
	        /// 文章内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public long CreateTime { get; set; }
	
	        /// <summary>
	        /// 摘要
	        /// </summary>
	        [XmlElement("digest")]
	        public string Digest { get; set; }
	
	        /// <summary>
	        /// 发布状态，0-未发布，1-已发布
	        /// </summary>
	        [XmlElement("publish_status")]
	        public long PublishStatus { get; set; }
	
	        /// <summary>
	        /// 发布时间
	        /// </summary>
	        [XmlElement("publish_time")]
	        public long PublishTime { get; set; }
	
	        /// <summary>
	        /// 封面图片的素材id
	        /// </summary>
	        [XmlElement("thumb_media_id")]
	        public string ThumbMediaId { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 阅读次数
	        /// </summary>
	        [XmlElement("total_view_count")]
	        public long TotalViewCount { get; set; }
	
	        /// <summary>
	        /// 修改时间
	        /// </summary>
	        [XmlElement("update_time")]
	        public long UpdateTime { get; set; }
	
	        /// <summary>
	        /// 文章链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
	
	        /// <summary>
	        /// 已读用户数
	        /// </summary>
	        [XmlElement("user_view_count")]
	        public long UserViewCount { get; set; }
}

	/// <summary>
/// NewsCardDTODomain Data Structure.
/// </summary>
[Serializable]

public class NewsCardDTODomain : TopObject
{
	        /// <summary>
	        /// 文章列表
	        /// </summary>
	        [XmlArray("articles")]
	        [XmlArrayItem("article_d_t_o")]
	        public List<ArticleDTODomain> Articles { get; set; }
	
	        /// <summary>
	        /// 消息卡片的素材id
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
	
	        /// <summary>
	        /// 消息卡片更新时间
	        /// </summary>
	        [XmlElement("update_time")]
	        public long UpdateTime { get; set; }
}

    }
}
