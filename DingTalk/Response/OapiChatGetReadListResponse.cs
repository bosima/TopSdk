using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiChatGetReadListResponse.
    /// </summary>
    public class OapiChatGetReadListResponse : DingTalkResponse
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
        /// next_cursor
        /// </summary>
        [XmlElement("next_cursor")]
        public long NextCursor { get; set; }

        /// <summary>
        /// readUserIdList
        /// </summary>
        [XmlArray("readUserIdList")]
        [XmlArrayItem("string")]
        public List<string> ReadUserIdList { get; set; }

    }
}
