using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceApproveFinishResponse.
    /// </summary>
    public class OapiAttendanceApproveFinishResponse : DingTalkResponse
    {
        /// <summary>
        /// 0代表成功，其他代表失败
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// demo
        /// </summary>
        [XmlElement("result")]
        public TopDurationVoDomain Result { get; set; }

	/// <summary>
/// TopDayDurationVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopDayDurationVoDomain : TopObject
{
	        /// <summary>
	        /// 日期
	        /// </summary>
	        [XmlElement("date")]
	        public string Date { get; set; }
	
	        /// <summary>
	        /// 每日时长
	        /// </summary>
	        [XmlElement("duration")]
	        public string Duration { get; set; }
}

	/// <summary>
/// TopDurationVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopDurationVoDomain : TopObject
{
	        /// <summary>
	        /// 总时长
	        /// </summary>
	        [XmlElement("duration")]
	        public string Duration { get; set; }
	
	        /// <summary>
	        /// demo
	        /// </summary>
	        [XmlArray("durationDetail")]
	        [XmlArrayItem("top_day_duration_vo")]
	        public List<TopDayDurationVoDomain> DurationDetail { get; set; }
}

    }
}
