using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiServiceaccountGetResponse.
    /// </summary>
    public class OapiServiceaccountGetResponse : DingTalkResponse
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
        /// 服务号详情
        /// </summary>
        [XmlElement("service_account")]
        public ServiceAccountDTODomain ServiceAccount { get; set; }

	/// <summary>
/// ServiceAccountDTODomain Data Structure.
/// </summary>
[Serializable]

public class ServiceAccountDTODomain : TopObject
{
	        /// <summary>
	        /// 头像图片mediaId
	        /// </summary>
	        [XmlElement("avatar_media_id")]
	        public string AvatarMediaId { get; set; }
	
	        /// <summary>
	        /// 机器人管理列表中的简介，最多60个字符
	        /// </summary>
	        [XmlElement("brief")]
	        public string Brief { get; set; }
	
	        /// <summary>
	        /// 机器人id
	        /// </summary>
	        [XmlElement("chat_bot_id")]
	        public string ChatBotId { get; set; }
	
	        /// <summary>
	        /// 机器人主页中的服务号功能简介，最多200个字符
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
	        /// 状态，normal-正常，disabled-删除
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
