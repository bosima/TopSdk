using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserGetUseridByUnionidResponse.
    /// </summary>
    public class OapiUserGetUseridByUnionidResponse : DingTalkResponse
    {
        /// <summary>
        /// contactType
        /// </summary>
        [XmlElement("contactType")]
        public long ContactType { get; set; }

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
        /// userid
        /// </summary>
        [XmlElement("userid")]
        public string Userid { get; set; }

    }
}
