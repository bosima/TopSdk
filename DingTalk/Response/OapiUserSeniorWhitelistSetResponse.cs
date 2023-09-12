using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserSeniorWhitelistSetResponse.
    /// </summary>
    public class OapiUserSeniorWhitelistSetResponse : DingTalkResponse
    {
        /// <summary>
        /// errCode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
