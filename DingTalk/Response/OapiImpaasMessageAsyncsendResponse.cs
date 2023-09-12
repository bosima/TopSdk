using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasMessageAsyncsendResponse.
    /// </summary>
    public class OapiImpaasMessageAsyncsendResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 返回描述信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 异步任务返回的ID
        /// </summary>
        [XmlElement("taskid")]
        public long Taskid { get; set; }

    }
}
