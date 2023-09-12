using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessWorkrecordTaskUpdateResponse.
    /// </summary>
    public class OapiProcessWorkrecordTaskUpdateResponse : DingTalkResponse
    {
        /// <summary>
        /// 0
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

    }
}
