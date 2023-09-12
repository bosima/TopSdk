using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSsoGetuserinfoResponse.
    /// </summary>
    public class OapiSsoGetuserinfoResponse : DingTalkResponse
    {
        /// <summary>
        /// corp_info
        /// </summary>
        [XmlElement("corp_info")]
        public CorpInfoDomain CorpInfo { get; set; }

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
        /// is_sys
        /// </summary>
        [XmlElement("is_sys")]
        public bool IsSys { get; set; }

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
	        /// avatar
	        /// </summary>
	        [XmlElement("avatar")]
	        public string Avatar { get; set; }
	
	        /// <summary>
	        /// email
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// name
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 员工在企业内的UserID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// CorpInfoDomain Data Structure.
/// </summary>
[Serializable]

public class CorpInfoDomain : TopObject
{
	        /// <summary>
	        /// 公司名字
	        /// </summary>
	        [XmlElement("corp_name")]
	        public string CorpName { get; set; }
	
	        /// <summary>
	        /// 公司corpid
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
}

    }
}
