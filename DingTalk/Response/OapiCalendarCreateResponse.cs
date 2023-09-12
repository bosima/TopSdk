using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCalendarCreateResponse.
    /// </summary>
    public class OapiCalendarCreateResponse : DingTalkResponse
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
        public CorpCalendarCreateResultDomain Result { get; set; }

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

    }
}
