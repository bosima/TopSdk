using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduClassconversationAsyncsendResponse.
    /// </summary>
    public class OapiEduClassconversationAsyncsendResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// TopSendConversationMsgResponseDomain Data Structure.
/// </summary>
[Serializable]

public class TopSendConversationMsgResponseDomain : TopObject
{
	        /// <summary>
	        /// 异步任务id
	        /// </summary>
	        [XmlElement("task_id")]
	        public string TaskId { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("errcode")]
	        public long Errcode { get; set; }
	
	        /// <summary>
	        /// 系统错误
	        /// </summary>
	        [XmlElement("errmsg")]
	        public string Errmsg { get; set; }
	
	        /// <summary>
	        /// response
	        /// </summary>
	        [XmlElement("response")]
	        public TopSendConversationMsgResponseDomain Response { get; set; }
	
	        /// <summary>
	        /// 调用是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
