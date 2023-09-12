using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMessageCorpconversationGetsendprogressResponse.
    /// </summary>
    public class OapiMessageCorpconversationGetsendprogressResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlElement("progress")]
        public AsyncSendProgressDomain Progress { get; set; }

	/// <summary>
/// AsyncSendProgressDomain Data Structure.
/// </summary>
[Serializable]

public class AsyncSendProgressDomain : TopObject
{
	        /// <summary>
	        /// 取值 0-100，表示处理的百分比
	        /// </summary>
	        [XmlElement("progress_in_percent")]
	        public long ProgressInPercent { get; set; }
	
	        /// <summary>
	        /// 任务执行状态,0=未开始,1=处理中,2=处理完毕
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
}

    }
}
