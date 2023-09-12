using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceVacationTypeUpdateResponse.
    /// </summary>
    public class OapiAttendanceVacationTypeUpdateResponse : DingTalkResponse
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
        /// 结果值
        /// </summary>
        [XmlElement("result")]
        public LeaveTypeVoDomain Result { get; set; }

        /// <summary>
        /// 是否正确访问
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// LeaveVisibilityRuleVoDomain Data Structure.
/// </summary>
[Serializable]

public class LeaveVisibilityRuleVoDomain : TopObject
{
	        /// <summary>
	        /// 规则类型：dept-部门；staff-员工；label-角色
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 规则数据：当type=staff时，为员工userId列表；当type=dept时，为部门id列表；当type=label时，为角色id列表
	        /// </summary>
	        [XmlArray("visible")]
	        [XmlArrayItem("string")]
	        public List<string> Visible { get; set; }
}

	/// <summary>
/// SubmitTimeRuleVoDomain Data Structure.
/// </summary>
[Serializable]

public class SubmitTimeRuleVoDomain : TopObject
{
	        /// <summary>
	        /// 是否开启限时提交功能：仅且为true时开启
	        /// </summary>
	        [XmlElement("enable_time_limit")]
	        public bool EnableTimeLimit { get; set; }
	
	        /// <summary>
	        /// 限制类型：before-提前；after-补交
	        /// </summary>
	        [XmlElement("time_type")]
	        public string TimeType { get; set; }
	
	        /// <summary>
	        /// 时间单位：day-天；hour-小时
	        /// </summary>
	        [XmlElement("time_unit")]
	        public string TimeUnit { get; set; }
	
	        /// <summary>
	        /// 限制值：timeUnit=day时，有效值范围[0~30] 天；timeUnit=hour时，有效值范围[0~24] 小时
	        /// </summary>
	        [XmlElement("time_value")]
	        public long TimeValue { get; set; }
}

	/// <summary>
/// LeaveCertificateVoDomain Data Structure.
/// </summary>
[Serializable]

public class LeaveCertificateVoDomain : TopObject
{
	        /// <summary>
	        /// 超过多长时间需提供请假证明
	        /// </summary>
	        [XmlElement("duration")]
	        public long Duration { get; set; }
	
	        /// <summary>
	        /// 是否开启请假证明
	        /// </summary>
	        [XmlElement("enable")]
	        public bool Enable { get; set; }
	
	        /// <summary>
	        /// 请假提示文案
	        /// </summary>
	        [XmlElement("prompt_information")]
	        public string PromptInformation { get; set; }
	
	        /// <summary>
	        /// 请假证明单位hour，day
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
}

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
	        /// 请假证明类
	        /// </summary>
	        [XmlElement("leave_certificate")]
	        public LeaveCertificateVoDomain LeaveCertificate { get; set; }
	
	        /// <summary>
	        /// 假期类型唯一标识
	        /// </summary>
	        [XmlElement("leave_code")]
	        public string LeaveCode { get; set; }
	
	        /// <summary>
	        /// 取整up或者down
	        /// </summary>
	        [XmlElement("leave_hour_ceil")]
	        public string LeaveHourCeil { get; set; }
	
	        /// <summary>
	        /// 假期名称
	        /// </summary>
	        [XmlElement("leave_name")]
	        public string LeaveName { get; set; }
	
	        /// <summary>
	        /// 是否开启请假时长是否向上取整
	        /// </summary>
	        [XmlElement("leave_time_ceil")]
	        public bool LeaveTimeCeil { get; set; }
	
	        /// <summary>
	        /// 请假时长向上取整时的最小时长单位：hour-不足1小时按照1小时计算；halfHour-不足半小时按照半小时计算
	        /// </summary>
	        [XmlElement("leave_time_ceil_min_unit")]
	        public string LeaveTimeCeilMinUnit { get; set; }
	
	        /// <summary>
	        /// 请假单位，可以按照天半天或者小时请假。(day、halfDay、hour其中一种)
	        /// </summary>
	        [XmlElement("leave_view_unit")]
	        public string LeaveViewUnit { get; set; }
	
	        /// <summary>
	        /// 最大请假时长
	        /// </summary>
	        [XmlElement("max_leave_time")]
	        public long MaxLeaveTime { get; set; }
	
	        /// <summary>
	        /// 请假时，最小请假时长（请假单位为hour时生效），请假时长小于该值时自动取该值，有效值：[0, 23]
	        /// </summary>
	        [XmlElement("min_leave_hour")]
	        public long MinLeaveHour { get; set; }
	
	        /// <summary>
	        /// 是否按照自然日统计请假时长，当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
	        /// </summary>
	        [XmlElement("natural_day_leave")]
	        public bool NaturalDayLeave { get; set; }
	
	        /// <summary>
	        /// 是否带薪假期
	        /// </summary>
	        [XmlElement("paid_leave")]
	        public bool PaidLeave { get; set; }
	
	        /// <summary>
	        /// 限时提交规则
	        /// </summary>
	        [XmlElement("submit_time_rule")]
	        public SubmitTimeRuleVoDomain SubmitTimeRule { get; set; }
	
	        /// <summary>
	        /// 适用范围规则列表：哪些部门/员工可以使用该假期类型
	        /// </summary>
	        [XmlArray("visibility_rules")]
	        [XmlArrayItem("leave_visibility_rule_vo")]
	        public List<LeaveVisibilityRuleVoDomain> VisibilityRules { get; set; }
	
	        /// <summary>
	        /// 新员工请假：何时可以请假（entry-入职开始 、formal-转正后）
	        /// </summary>
	        [XmlElement("when_can_leave")]
	        public string WhenCanLeave { get; set; }
}

    }
}
