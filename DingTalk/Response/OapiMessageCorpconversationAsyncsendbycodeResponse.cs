using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMessageCorpconversationAsyncsendbycodeResponse.
    /// </summary>
    public class OapiMessageCorpconversationAsyncsendbycodeResponse : DingTalkResponse
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
        /// 异步发送任务的id
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }

    }
}
