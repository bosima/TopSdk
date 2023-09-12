using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasMessageGetmessagestatusResponse.
    /// </summary>
    public class OapiImpaasMessageGetmessagestatusResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public GetMessageStatusResponseDomain Result { get; set; }

	/// <summary>
/// GetMessageStatusResponseDomain Data Structure.
/// </summary>
[Serializable]

public class GetMessageStatusResponseDomain : TopObject
{
	        /// <summary>
	        /// 消息任务执行返回码 0表示成功
	        /// </summary>
	        [XmlElement("task_code")]
	        public long TaskCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("task_msg")]
	        public string TaskMsg { get; set; }
	
	        /// <summary>
	        /// 消息任务执行状态 0：初始化，刚提交时的状态 3：处理中 4：处理完成 5：撤销
	        /// </summary>
	        [XmlElement("task_status")]
	        public long TaskStatus { get; set; }
}

    }
}
