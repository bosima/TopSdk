using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiOpenencryptHeartbeatResponse.
    /// </summary>
    public class OapiOpenencryptHeartbeatResponse : DingTalkResponse
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

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// true
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
