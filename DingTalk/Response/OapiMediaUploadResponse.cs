using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMediaUploadResponse.
    /// </summary>
    public class OapiMediaUploadResponse : DingTalkResponse
    {
        /// <summary>
        /// 媒体文件上传时间戳
        /// </summary>
        [XmlElement("created_at")]
        public long CreatedAt { get; set; }

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
        /// 媒体文件上传后获取的唯一标识
        /// </summary>
        [XmlElement("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// 媒体文件类型，分别有图片（image）、语音（voice）、普通文件(file)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

    }
}
