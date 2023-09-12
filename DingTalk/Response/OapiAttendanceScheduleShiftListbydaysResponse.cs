using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceScheduleShiftListbydaysResponse.
    /// </summary>
    public class OapiAttendanceScheduleShiftListbydaysResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("top_day_schedule_shift_vo")]
        public List<TopDayScheduleShiftVoDomain> Result { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TopDayScheduleShiftVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopDayScheduleShiftVoDomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 考勤组id
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// 班次id
	        /// </summary>
	        [XmlArray("shift_ids")]
	        [XmlArrayItem("number")]
	        public List<long> ShiftIds { get; set; }
	
	        /// <summary>
	        /// 班次名称
	        /// </summary>
	        [XmlArray("shift_names")]
	        [XmlArrayItem("string")]
	        public List<string> ShiftNames { get; set; }
	
	        /// <summary>
	        /// 班次版本id
	        /// </summary>
	        [XmlArray("shift_versions")]
	        [XmlArrayItem("number")]
	        public List<long> ShiftVersions { get; set; }
	
	        /// <summary>
	        /// 人员userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 工作日
	        /// </summary>
	        [XmlElement("work_date")]
	        public string WorkDate { get; set; }
}

    }
}
