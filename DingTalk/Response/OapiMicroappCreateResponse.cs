using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMicroappCreateResponse.
    /// </summary>
    public class OapiMicroappCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// agentid
        /// </summary>
        [XmlElement("agentid")]
        public long Agentid { get; set; }

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

    }
}
