using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiGetJsapiTicketResponse.
    /// </summary>
    public class OapiGetJsapiTicketResponse : DingTalkResponse
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
        /// 票据过期时间
        /// </summary>
        [XmlElement("expires_in")]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// 用于JS API的临时票据
        /// </summary>
        [XmlElement("ticket")]
        public string Ticket { get; set; }

    }
}
