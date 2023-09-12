using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserCreateResponse.
    /// </summary>
    public class OapiUserCreateResponse : DingTalkResponse
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
        /// unionId
        /// </summary>
        [XmlElement("unionId")]
        public string UnionId { get; set; }

        /// <summary>
        /// userid
        /// </summary>
        [XmlElement("userid")]
        public string Userid { get; set; }

    }
}
