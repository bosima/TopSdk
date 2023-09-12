using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpExtAddResponse.
    /// </summary>
    public class CorpExtAddResponse : DingTalkResponse
    {
        /// <summary>
        /// 新外部联系人的userId
        /// </summary>
        [XmlElement("userid")]
        public string Userid { get; set; }

    }
}
