using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProjectInviteShareurlGetResponse.
    /// </summary>
    public class OapiProjectInviteShareurlGetResponse : DingTalkResponse
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
        /// 响应结果
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 该二维码有效时间，以秒为单位。 最大不超过2592000（即30天）。
	        /// </summary>
	        [XmlElement("expire_seconds")]
	        public long ExpireSeconds { get; set; }
	
	        /// <summary>
	        /// 圈子专属链接
	        /// </summary>
	        [XmlElement("h5_url_circle")]
	        public string H5UrlCircle { get; set; }
	
	        /// <summary>
	        /// 群专属链接
	        /// </summary>
	        [XmlElement("h5_url_group")]
	        public string H5UrlGroup { get; set; }
}

    }
}
