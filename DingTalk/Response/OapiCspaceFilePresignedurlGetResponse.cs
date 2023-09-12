using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCspaceFilePresignedurlGetResponse.
    /// </summary>
    public class OapiCspaceFilePresignedurlGetResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("presigned_url_result")]
        public GenerateUrlResultDomain PresignedUrlResult { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// GenerateUrlResultDomain Data Structure.
/// </summary>
[Serializable]

public class GenerateUrlResultDomain : TopObject
{
	        /// <summary>
	        /// 验证码，此属性无需关注
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 文件唯一标识，此属性无需关注
	        /// </summary>
	        [XmlElement("mediaid")]
	        public string Mediaid { get; set; }
	
	        /// <summary>
	        /// 文件下载Url
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

    }
}
