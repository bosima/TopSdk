using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSnsGetSnsTokenResponse.
    /// </summary>
    public class OapiSnsGetSnsTokenResponse : DingTalkResponse
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
        /// sns_token的过期时间
        /// </summary>
        [XmlElement("expires_in")]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// 用户授权的token
        /// </summary>
        [XmlElement("sns_token")]
        public string SnsToken { get; set; }

    }
}
