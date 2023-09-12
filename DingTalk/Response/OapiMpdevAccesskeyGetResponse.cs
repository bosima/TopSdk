using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMpdevAccesskeyGetResponse.
    /// </summary>
    public class OapiMpdevAccesskeyGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误文案
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回内容
        /// </summary>
        [XmlElement("result")]
        public OssTokenVoDomain Result { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OssTokenVoDomain Data Structure.
/// </summary>
[Serializable]

public class OssTokenVoDomain : TopObject
{
	        /// <summary>
	        /// accessKeySecret
	        /// </summary>
	        [XmlElement("access_key_secret")]
	        public string AccessKeySecret { get; set; }
	
	        /// <summary>
	        /// accessid
	        /// </summary>
	        [XmlElement("accessid")]
	        public string Accessid { get; set; }
	
	        /// <summary>
	        /// 失效时间
	        /// </summary>
	        [XmlElement("expiration")]
	        public string Expiration { get; set; }
	
	        /// <summary>
	        /// 上传文件名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// securityToken
	        /// </summary>
	        [XmlElement("security_token")]
	        public string SecurityToken { get; set; }
}

    }
}
