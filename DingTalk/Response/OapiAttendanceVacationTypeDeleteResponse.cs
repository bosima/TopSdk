using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceVacationTypeDeleteResponse.
    /// </summary>
    public class OapiAttendanceVacationTypeDeleteResponse : DingTalkResponse
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
        /// LeaveTypeVo
        /// </summary>
        [XmlElement("result")]
        public LeaveTypeVoDomain Result { get; set; }

        /// <summary>
        /// 是否正确访问
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// LeaveTypeVoDomain Data Structure.
/// </summary>
[Serializable]

public class LeaveTypeVoDomain : TopObject
{
	        /// <summary>
	        /// 假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)
	        /// </summary>
	        [XmlElement("biz_type")]
	        public string BizType { get; set; }
	
	        /// <summary>
	        /// 每天折算的工作时长(百分之一 例如1天=10小时=1000)
	        /// </summary>
	        [XmlElement("hours_in_per_day")]
	        public long HoursInPerDay { get; set; }
	
	        /// <summary>
	        /// 假期类型唯一标示
	        /// </summary>
	        [XmlElement("leave_code")]
	        public string LeaveCode { get; set; }
	
	        /// <summary>
	        /// 假期名称
	        /// </summary>
	        [XmlElement("leave_name")]
	        public string LeaveName { get; set; }
	
	        /// <summary>
	        /// 请假单位，可以按照天半天或者小时请假。(day、halfday、hour其中一种)
	        /// </summary>
	        [XmlElement("leave_view_unit")]
	        public string LeaveViewUnit { get; set; }
	
	        /// <summary>
	        /// 是否按照自然日统计请假时长，当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
	        /// </summary>
	        [XmlElement("natural_day_leave")]
	        public bool NaturalDayLeave { get; set; }
}

    }
}
