using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiServiceGetSuiteTokenResponse.
    /// </summary>
    public class OapiServiceGetSuiteTokenResponse : DingTalkResponse
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
        /// 有效期7200秒，过期之前要主动更新（建议ISV服务端做定时器主动更新，而不是依赖钉钉的定时推送）
        /// </summary>
        [XmlElement("expires_in")]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// 应用套件access_token
        /// </summary>
        [XmlElement("suite_access_token")]
        public string SuiteAccessToken { get; set; }

    }
}
