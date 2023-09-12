using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasConversationCreateResponse.
    /// </summary>
    public class OapiImpaasConversationCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 群id
        /// </summary>
        [XmlElement("chatid")]
        public string Chatid { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

    }
}
