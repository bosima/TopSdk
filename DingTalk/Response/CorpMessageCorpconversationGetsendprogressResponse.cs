using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpMessageCorpconversationGetsendprogressResponse.
    /// </summary>
    public class CorpMessageCorpconversationGetsendprogressResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

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

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlElement("progress")]
	        public AsyncSendProgressDomain Progress { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
