using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCspaceAuthUpdateResponse.
    /// </summary>
    public class OapiCspaceAuthUpdateResponse : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public IsvAuthCodeResultDomain Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// IsvAuthCodeResultDomain Data Structure.
/// </summary>
[Serializable]

public class IsvAuthCodeResultDomain : TopObject
{
	        /// <summary>
	        /// 授权码有效期，unix时间戳，单位ms
	        /// </summary>
	        [XmlElement("expire_time")]
	        public string ExpireTime { get; set; }
	
	        /// <summary>
	        /// 授权码
	        /// </summary>
	        [XmlElement("isv_code")]
	        public string IsvCode { get; set; }
}

    }
}
