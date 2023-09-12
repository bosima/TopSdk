using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiVillageScreenGetResponse.
    /// </summary>
    public class OapiVillageScreenGetResponse : DingTalkResponse
    {
        /// <summary>
        /// -
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
