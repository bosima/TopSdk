using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMicroappCustomDeleteResponse.
    /// </summary>
    public class OapiMicroappCustomDeleteResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误码文案
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

    }
}
