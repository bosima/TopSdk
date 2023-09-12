using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSceneservicegroupGroupsetCreateResponse.
    /// </summary>
    public class OapiSceneservicegroupGroupsetCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 开放群组ID
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
