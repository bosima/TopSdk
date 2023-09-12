using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserCanAccessMicroappResponse.
    /// </summary>
    public class OapiUserCanAccessMicroappResponse : DingTalkResponse
    {
        /// <summary>
        /// canAccess
        /// </summary>
        [XmlElement("canAccess")]
        public bool CanAccess { get; set; }

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
