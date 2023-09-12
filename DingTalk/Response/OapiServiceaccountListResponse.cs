using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiServiceaccountListResponse.
    /// </summary>
    public class OapiServiceaccountListResponse : DingTalkResponse
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
        /// 当前记录数
        /// </summary>
        [XmlElement("item_count")]
        public long ItemCount { get; set; }

        /// <summary>
        /// 服务号列表
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("publisher_d_t_o")]
        public List<PublisherDTODomain> Items { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

	/// <summary>
/// PublisherDTODomain Data Structure.
/// </summary>
[Serializable]

public class PublisherDTODomain : TopObject
{
	        /// <summary>
	        /// 头像图片mediaId
	        /// </summary>
	        [XmlElement("avatar_media_id")]
	        public string AvatarMediaId { get; set; }
	
	        /// <summary>
	        /// 机器人管理列表中的简介
	        /// </summary>
	        [XmlElement("brief")]
	        public string Brief { get; set; }
	
	        /// <summary>
	        /// 机器人主页中的服务号功能简介
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 服务号名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 机器人主页中，消息预览图片的mediaId
	        /// </summary>
	        [XmlElement("preview_media_id")]
	        public string PreviewMediaId { get; set; }
	
	        /// <summary>
	        /// 状态，normal-正常，disabled-停用
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 服务号的unionid
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
}

    }
}
