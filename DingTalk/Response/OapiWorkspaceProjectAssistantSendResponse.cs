using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkspaceProjectAssistantSendResponse.
    /// </summary>
    public class OapiWorkspaceProjectAssistantSendResponse : DingTalkResponse
    {
        /// <summary>
        /// errorcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// errorcode
        /// </summary>
        [XmlElement("msgCode")]
        public string MsgCode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("msgInfo")]
        public string MsgInfo { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
