using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceTokenGetResponse.
    /// </summary>
    public class OapiAttendanceTokenGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 方法调用结果
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// TokenVODomain Data Structure.
/// </summary>
[Serializable]

public class TokenVODomain : TopObject
{
	        /// <summary>
	        /// 授权超时时间
	        /// </summary>
	        [XmlElement("expire_time")]
	        public long ExpireTime { get; set; }
	
	        /// <summary>
	        /// 授权码
	        /// </summary>
	        [XmlElement("token")]
	        public string Token { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
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
	        /// 业务返回结果
	        /// </summary>
	        [XmlElement("result")]
	        public TokenVODomain Result { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
