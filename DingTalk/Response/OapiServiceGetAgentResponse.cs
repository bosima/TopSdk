using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiServiceGetAgentResponse.
    /// </summary>
    public class OapiServiceGetAgentResponse : DingTalkResponse
    {
        /// <summary>
        /// agentid
        /// </summary>
        [XmlElement("agentid")]
        public long Agentid { get; set; }

        /// <summary>
        /// close
        /// </summary>
        [XmlElement("close")]
        public long Close { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

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
        /// logo_url
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

    }
}
