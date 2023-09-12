using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasGroupCreateResponse.
    /// </summary>
    public class OapiImpaasGroupCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 群ID
        /// </summary>
        [XmlElement("chatid")]
        public string Chatid { get; set; }

        /// <summary>
        /// 错误码，0为成功
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

    }
}
