using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSnsSyncActivityResponse.
    /// </summary>
    public class OapiSnsSyncActivityResponse : DingTalkResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

    }
}
