using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiGettokenResponse.
    /// </summary>
    public class OapiGettokenResponse : DingTalkResponse
    {
        /// <summary>
        /// access_token
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
        /// expires_in
        /// </summary>
        [XmlElement("expires_in")]
        public long ExpiresIn { get; set; }

    }
}
