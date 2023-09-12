using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpCalendarCreateResponse.
    /// </summary>
    public class CorpCalendarCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// CorpCalendarCreateResultDomain Data Structure.
/// </summary>
[Serializable]

public class CorpCalendarCreateResultDomain : TopObject
{
	        /// <summary>
	        /// dingtalkCalendarId
	        /// </summary>
	        [XmlElement("dingtalk_calendar_id")]
	        public string DingtalkCalendarId { get; set; }
	
	        /// <summary>
	        /// invalidUser
	        /// </summary>
	        [XmlArray("invalid_userids")]
	        [XmlArrayItem("string")]
	        public List<string> InvalidUserids { get; set; }
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
	        [XmlElement("result")]
	        public CorpCalendarCreateResultDomain Result { get; set; }
	
	        /// <summary>
	        /// 创建结果
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
