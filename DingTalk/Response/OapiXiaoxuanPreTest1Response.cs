using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiXiaoxuanPreTest1Response.
    /// </summary>
    public class OapiXiaoxuanPreTest1Response : DingTalkResponse
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
        /// 1
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("resultData")]
        public string ResultData { get; set; }

    }
}
