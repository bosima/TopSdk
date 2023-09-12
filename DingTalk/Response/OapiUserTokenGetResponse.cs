using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserTokenGetResponse.
    /// </summary>
    public class OapiUserTokenGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码。0代表成功。
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public UserToken4JsapiResponseDomain Result { get; set; }

	/// <summary>
/// UserToken4JsapiResponseDomain Data Structure.
/// </summary>
[Serializable]

public class UserToken4JsapiResponseDomain : TopObject
{
	        /// <summary>
	        /// 个人token
	        /// </summary>
	        [XmlElement("access_token")]
	        public string AccessToken { get; set; }
	
	        /// <summary>
	        /// token有效期
	        /// </summary>
	        [XmlElement("expire_in")]
	        public long ExpireIn { get; set; }
}

    }
}
