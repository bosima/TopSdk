using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiServiceGetUnactiveCorpResponse.
    /// </summary>
    public class OapiServiceGetUnactiveCorpResponse : DingTalkResponse
    {
        /// <summary>
        /// app_id
        /// </summary>
        [XmlElement("app_id")]
        public long AppId { get; set; }

        /// <summary>
        /// corp_list
        /// </summary>
        [XmlArray("corp_list")]
        [XmlArrayItem("string")]
        public List<string> CorpList { get; set; }

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
        /// has_more
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

    }
}
