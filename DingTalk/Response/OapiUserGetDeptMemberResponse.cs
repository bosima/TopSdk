using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserGetDeptMemberResponse.
    /// </summary>
    public class OapiUserGetDeptMemberResponse : DingTalkResponse
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
        /// userIds
        /// </summary>
        [XmlArray("userIds")]
        [XmlArrayItem("string")]
        public List<string> UserIds { get; set; }

    }
}
