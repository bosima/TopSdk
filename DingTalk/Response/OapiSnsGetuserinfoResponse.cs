using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSnsGetuserinfoResponse.
    /// </summary>
    public class OapiSnsGetuserinfoResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// user_info
        /// </summary>
        [XmlElement("user_info")]
        public UserInfoDomain UserInfo { get; set; }

	/// <summary>
/// UserInfoDomain Data Structure.
/// </summary>
[Serializable]

public class UserInfoDomain : TopObject
{
	        /// <summary>
	        /// 钉钉Id
	        /// </summary>
	        [XmlElement("dingId")]
	        public string DingId { get; set; }
	
	        /// <summary>
	        /// maskedMobile
	        /// </summary>
	        [XmlElement("maskedMobile")]
	        public string MaskedMobile { get; set; }
	
	        /// <summary>
	        /// 用户在钉钉上面的昵称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 用户在当前开放应用内的唯一标识
	        /// </summary>
	        [XmlElement("openid")]
	        public string Openid { get; set; }
	
	        /// <summary>
	        /// 用户在当前开放应用所属的钉钉开放平台账号内的唯一标识
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
}

    }
}
