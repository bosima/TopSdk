using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSnsGetuserinfoBycodeResponse.
    /// </summary>
    public class OapiSnsGetuserinfoBycodeResponse : DingTalkResponse
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
	        /// 用户主企业是否达到高级认证级别
	        /// </summary>
	        [XmlElement("main_org_auth_high_level")]
	        public bool MainOrgAuthHighLevel { get; set; }
	
	        /// <summary>
	        /// nick
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// openid
	        /// </summary>
	        [XmlElement("openid")]
	        public string Openid { get; set; }
	
	        /// <summary>
	        /// unionid
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
}

    }
}
