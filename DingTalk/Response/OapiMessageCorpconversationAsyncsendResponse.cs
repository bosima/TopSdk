using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMessageCorpconversationAsyncsendResponse.
    /// </summary>
    public class OapiMessageCorpconversationAsyncsendResponse : DingTalkResponse
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
        /// 创建的异步发送任务id
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }

    }
}
