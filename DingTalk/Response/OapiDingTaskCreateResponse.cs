using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingTaskCreateResponse.
    /// </summary>
    public class OapiDingTaskCreateResponse : DingTalkResponse
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
        public TaskSendResultDomain Result { get; set; }

	/// <summary>
/// TaskSendResultDomain Data Structure.
/// </summary>
[Serializable]

public class TaskSendResultDomain : TopObject
{
	        /// <summary>
	        /// dingId
	        /// </summary>
	        [XmlElement("ding_id")]
	        public string DingId { get; set; }
}

    }
}
