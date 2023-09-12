using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingTaskStatusUpdateResponse.
    /// </summary>
    public class OapiDingTaskStatusUpdateResponse : DingTalkResponse
    {
        /// <summary>
        /// errorcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errormsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
