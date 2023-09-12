using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserGetAdminScopeResponse.
    /// </summary>
    public class OapiUserGetAdminScopeResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlArray("dept_ids")]
        [XmlArrayItem("number")]
        public List<long> DeptIds { get; set; }

        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

    }
}
