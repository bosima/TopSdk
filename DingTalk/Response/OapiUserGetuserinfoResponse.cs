using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserGetuserinfoResponse.
    /// </summary>
    public class OapiUserGetuserinfoResponse : DingTalkResponse
    {
        /// <summary>
        /// deviceId
        /// </summary>
        [XmlElement("deviceId")]
        public string DeviceId { get; set; }

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
        /// is_sys
        /// </summary>
        [XmlElement("is_sys")]
        public bool IsSys { get; set; }

        /// <summary>
        /// sys_level
        /// </summary>
        [XmlElement("sys_level")]
        public string SysLevel { get; set; }

        /// <summary>
        /// userid
        /// </summary>
        [XmlElement("userid")]
        public string Userid { get; set; }

    }
}
