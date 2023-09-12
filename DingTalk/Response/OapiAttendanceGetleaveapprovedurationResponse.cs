using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGetleaveapprovedurationResponse.
    /// </summary>
    public class OapiAttendanceGetleaveapprovedurationResponse : DingTalkResponse
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
        [XmlElement("result")]
        public ApproveDurationForTopVoDomain Result { get; set; }

	/// <summary>
/// ApproveDurationForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ApproveDurationForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 请假时长（单位分钟）
	        /// </summary>
	        [XmlElement("duration_in_minutes")]
	        public long DurationInMinutes { get; set; }
}

    }
}
