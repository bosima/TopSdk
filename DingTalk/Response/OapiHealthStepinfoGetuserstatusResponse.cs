using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiHealthStepinfoGetuserstatusResponse.
    /// </summary>
    public class OapiHealthStepinfoGetuserstatusResponse : DingTalkResponse
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
        /// true表示开启，false表示未开启
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }

    }
}
