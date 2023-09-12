using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiServiceGetAuthInfoResponse.
    /// </summary>
    public class OapiServiceGetAuthInfoResponse : DingTalkResponse
    {
        /// <summary>
        /// auth_corp_info
        /// </summary>
        [XmlElement("auth_corp_info")]
        public AuthCorpInfoDomain AuthCorpInfo { get; set; }

        /// <summary>
        /// auth_info
        /// </summary>
        [XmlElement("auth_info")]
        public AuthInfoDomain AuthInfo { get; set; }

        /// <summary>
        /// auth_user_info
        /// </summary>
        [XmlElement("auth_user_info")]
        public AuthUserInfoDomain AuthUserInfo { get; set; }

        /// <summary>
        /// channel_auth_info
        /// </summary>
        [XmlElement("channel_auth_info")]
        public ChannelAuthInfoDomain ChannelAuthInfo { get; set; }

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
/// AgentDomain Data Structure.
/// </summary>
[Serializable]

public class AgentDomain : TopObject
{
	        /// <summary>
	        /// admin_list
	        /// </summary>
	        [XmlArray("admin_list")]
	        [XmlArrayItem("string")]
	        public List<string> AdminList { get; set; }
	
	        /// <summary>
	        /// agent_name
	        /// </summary>
	        [XmlElement("agent_name")]
	        public string AgentName { get; set; }
	
	        /// <summary>
	        /// agentid
	        /// </summary>
	        [XmlElement("agentid")]
	        public long Agentid { get; set; }
	
	        /// <summary>
	        /// appid
	        /// </summary>
	        [XmlElement("appid")]
	        public long Appid { get; set; }
	
	        /// <summary>
	        /// logo_url
	        /// </summary>
	        [XmlElement("logo_url")]
	        public string LogoUrl { get; set; }
}

	/// <summary>
/// AuthInfoDomain Data Structure.
/// </summary>
[Serializable]

public class AuthInfoDomain : TopObject
{
	        /// <summary>
	        /// agent
	        /// </summary>
	        [XmlArray("agent")]
	        [XmlArrayItem("agent")]
	        public List<AgentDomain> Agent { get; set; }
}

	/// <summary>
/// AuthUserInfoDomain Data Structure.
/// </summary>
[Serializable]

public class AuthUserInfoDomain : TopObject
{
	        /// <summary>
	        /// userId
	        /// </summary>
	        [XmlElement("userId")]
	        public string UserId { get; set; }
}

	/// <summary>
/// AuthCorpInfoDomain Data Structure.
/// </summary>
[Serializable]

public class AuthCorpInfoDomain : TopObject
{
	        /// <summary>
	        /// auth_channel
	        /// </summary>
	        [XmlElement("auth_channel")]
	        public string AuthChannel { get; set; }
	
	        /// <summary>
	        /// auth_channel_type
	        /// </summary>
	        [XmlElement("auth_channel_type")]
	        public string AuthChannelType { get; set; }
	
	        /// <summary>
	        /// auth_level
	        /// </summary>
	        [XmlElement("auth_level")]
	        public long AuthLevel { get; set; }
	
	        /// <summary>
	        /// belong_corp_id
	        /// </summary>
	        [XmlElement("belong_corp_id")]
	        public string BelongCorpId { get; set; }
	
	        /// <summary>
	        /// corp_logo_url
	        /// </summary>
	        [XmlElement("corp_logo_url")]
	        public string CorpLogoUrl { get; set; }
	
	        /// <summary>
	        /// corp_name
	        /// </summary>
	        [XmlElement("corp_name")]
	        public string CorpName { get; set; }
	
	        /// <summary>
	        /// corpid
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// full_corp_name
	        /// </summary>
	        [XmlElement("full_corp_name")]
	        public string FullCorpName { get; set; }
	
	        /// <summary>
	        /// industry
	        /// </summary>
	        [XmlElement("industry")]
	        public string Industry { get; set; }
	
	        /// <summary>
	        /// invite_code
	        /// </summary>
	        [XmlElement("invite_code")]
	        public string InviteCode { get; set; }
	
	        /// <summary>
	        /// invite_url
	        /// </summary>
	        [XmlElement("invite_url")]
	        public string InviteUrl { get; set; }
	
	        /// <summary>
	        /// is_authenticated
	        /// </summary>
	        [XmlElement("is_authenticated")]
	        public bool IsAuthenticated { get; set; }
	
	        /// <summary>
	        /// license_code
	        /// </summary>
	        [XmlElement("license_code")]
	        public string LicenseCode { get; set; }
	
	        /// <summary>
	        /// unifiedSocialCredit
	        /// </summary>
	        [XmlElement("unifiedSocialCredit")]
	        public string UnifiedSocialCredit { get; set; }
}

	/// <summary>
/// ChannelagentDomain Data Structure.
/// </summary>
[Serializable]

public class ChannelagentDomain : TopObject
{
	        /// <summary>
	        /// agent_name
	        /// </summary>
	        [XmlElement("agent_name")]
	        public string AgentName { get; set; }
	
	        /// <summary>
	        /// agentid
	        /// </summary>
	        [XmlElement("agentid")]
	        public long Agentid { get; set; }
	
	        /// <summary>
	        /// appid
	        /// </summary>
	        [XmlElement("appid")]
	        public long Appid { get; set; }
	
	        /// <summary>
	        /// logo_url
	        /// </summary>
	        [XmlElement("logo_url")]
	        public string LogoUrl { get; set; }
}

	/// <summary>
/// ChannelAuthInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ChannelAuthInfoDomain : TopObject
{
	        /// <summary>
	        /// channelAgent
	        /// </summary>
	        [XmlArray("channelAgent")]
	        [XmlArrayItem("channelagent")]
	        public List<ChannelagentDomain> ChannelAgent { get; set; }
}

    }
}
