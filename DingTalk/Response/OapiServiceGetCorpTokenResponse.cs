using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiServiceGetCorpTokenResponse.
    /// </summary>
    public class OapiServiceGetCorpTokenResponse : DingTalkResponse
    {
        /// <summary>
        /// 授权方（企业）corp_access_token
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

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
        /// 授权方（企业）corp_access_token超时时间
        /// </summary>
        [XmlElement("expires_in")]
        public long ExpiresIn { get; set; }

    }
}
