using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiIsvOpenencryptHeartbeatResponse.
    /// </summary>
    public class OapiIsvOpenencryptHeartbeatResponse : DingTalkResponse
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
        /// 一般是空字符串
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// true
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
