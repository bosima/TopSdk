using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMaterialArticleGetResponse.
    /// </summary>
    public class OapiMaterialArticleGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 文章id
        /// </summary>
        [XmlElement("article_id")]
        public long ArticleId { get; set; }

        /// <summary>
        /// html码
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
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 发布状态
        /// </summary>
        [XmlElement("publish_status")]
        public long PublishStatus { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("publish_time")]
        public long PublishTime { get; set; }

        /// <summary>
        /// 封面图
        /// </summary>
        [XmlElement("thumb_media_id")]
        public string ThumbMediaId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("update_time")]
        public long UpdateTime { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

    }
}
