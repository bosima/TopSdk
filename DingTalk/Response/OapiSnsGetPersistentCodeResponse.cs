using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSnsGetPersistentCodeResponse.
    /// </summary>
    public class OapiSnsGetPersistentCodeResponse : DingTalkResponse
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
        /// 用户在当前开放应用内的唯一标识
        /// </summary>
        [XmlElement("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 用户给开放应用授权的持久授权码，此码目前无过期时间
        /// </summary>
        [XmlElement("persistent_code")]
        public string PersistentCode { get; set; }

        /// <summary>
        /// 用户在当前钉钉开放平台账号范围内的唯一标识，同一个钉钉开放平台账号可以包含多个开放应用，同时也包含ISV的套件应用及企业应用
        /// </summary>
        [XmlElement("unionid")]
        public string Unionid { get; set; }

    }
}
