using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiXiaoqianApiTestResponse.
    /// </summary>
    public class OapiXiaoqianApiTestResponse : DingTalkResponse
    {
        /// <summary>
        /// code
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// msg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
