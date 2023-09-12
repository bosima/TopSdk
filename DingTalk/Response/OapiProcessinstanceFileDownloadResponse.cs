using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessinstanceFileDownloadResponse.
    /// </summary>
    public class OapiProcessinstanceFileDownloadResponse : DingTalkResponse
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
        /// 返回数据
        /// </summary>
        [XmlElement("result")]
        public AppSpaceResponseDomain Result { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// AppSpaceResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AppSpaceResponseDomain : TopObject
{
	        /// <summary>
	        /// 临时授权码
	        /// </summary>
	        [XmlElement("auth_code")]
	        public string AuthCode { get; set; }
	
	        /// <summary>
	        /// 钉盘空间id
	        /// </summary>
	        [XmlElement("space_id")]
	        public long SpaceId { get; set; }
}

    }
}
