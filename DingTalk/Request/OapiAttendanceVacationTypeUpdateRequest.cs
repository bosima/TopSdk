using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.vacation.type.update
    /// </summary>
    public class OapiAttendanceVacationTypeUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceVacationTypeUpdateResponse>
    {
        /// <summary>
        /// 假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 调休假有效期规则(validity_type:有效类型 absolute_time(绝对时间)、relative_time(相对时间)其中一种 validity_value:延长日期(当validity_type为absolute_time该值该值不为空且满足yy-mm格式 validity_type为relative_time该值为大于1的整数))
        /// </summary>
        public string Extras { get; set; }

        /// <summary>
        /// 每天折算的工作时长(百分之一 例如1天=10小时=1000)
        /// </summary>
        public Nullable<long> HoursInPerDay { get; set; }

        /// <summary>
        /// 请假证明类
        /// </summary>
        public string LeaveCertificate { get; set; }

        public LeaveCertificateVoDomain LeaveCertificate_ { set { this.LeaveCertificate = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 假期类型唯一标识
        /// </summary>
        public string LeaveCode { get; set; }

        /// <summary>
        /// 取整，up或者down
        /// </summary>
        public string LeaveHourCeil { get; set; }

        /// <summary>
        /// 假期名称
        /// </summary>
        public string LeaveName { get; set; }

        /// <summary>
        /// 是否开启请假时长是否向上取整
        /// </summary>
        public Nullable<bool> LeaveTimeCeil { get; set; }

        /// <summary>
        /// 请假时长向上取整时的最小时长单位：hour-不足1小时按照1小时计算；halfHour-不足半小时按照半小时计算
        /// </summary>
        public string LeaveTimeCeilMinUnit { get; set; }

        /// <summary>
        /// 请假单位，可以按照天半天或者小时请假。(day、halfDay、hour其中一种)
        /// </summary>
        public string LeaveViewUnit { get; set; }

        /// <summary>
        /// 最大请假时间
        /// </summary>
        public Nullable<long> MaxLeaveTime { get; set; }

        /// <summary>
        /// 请假时，最小请假时长（请假单位为hour时生效），请假时长小于该值时自动取该值，有效值：[0, 23]
        /// </summary>
        public Nullable<long> MinLeaveHour { get; set; }

        /// <summary>
        /// 是否按照自然日统计请假时长，当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
        /// </summary>
        public Nullable<bool> NaturalDayLeave { get; set; }

        /// <summary>
        /// 操作者ID
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 是否带薪假期
        /// </summary>
        public Nullable<bool> PaidLeave { get; set; }

        /// <summary>
        /// 限时提交规则
        /// </summary>
        public string SubmitTimeRule { get; set; }

        public SubmitTimeRuleVoDomain SubmitTimeRule_ { set { this.SubmitTimeRule = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 适用范围规则列表：哪些部门/员工可以使用该假期类型，不传默认为全公司
        /// </summary>
        public string VisibilityRules { get; set; }

        public List<LeaveVisibilityRuleVoDomain> VisibilityRules_ { set { this.VisibilityRules = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 新员工请假：何时可以请假（entry-入职开始 、formal-转正后）
        /// </summary>
        public string WhenCanLeave { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.vacation.type.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
            parameters.Add("extras", this.Extras);
            parameters.Add("hours_in_per_day", this.HoursInPerDay);
            parameters.Add("leave_certificate", this.LeaveCertificate);
            parameters.Add("leave_code", this.LeaveCode);
            parameters.Add("leave_hour_ceil", this.LeaveHourCeil);
            parameters.Add("leave_name", this.LeaveName);
            parameters.Add("leave_time_ceil", this.LeaveTimeCeil);
            parameters.Add("leave_time_ceil_min_unit", this.LeaveTimeCeilMinUnit);
            parameters.Add("leave_view_unit", this.LeaveViewUnit);
            parameters.Add("max_leave_time", this.MaxLeaveTime);
            parameters.Add("min_leave_hour", this.MinLeaveHour);
            parameters.Add("natural_day_leave", this.NaturalDayLeave);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("paid_leave", this.PaidLeave);
            parameters.Add("submit_time_rule", this.SubmitTimeRule);
            parameters.Add("visibility_rules", this.VisibilityRules);
            parameters.Add("when_can_leave", this.WhenCanLeave);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("leave_code", this.LeaveCode);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateObjectMaxListSize("visibility_rules", this.VisibilityRules, 999);
        }

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
	        /// 规则数据：当type=staff时，传员工userId列表；当type=dept时，传部门id列表；当type=label时，传角色id列表
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
	        public Nullable<bool> EnableTimeLimit { get; set; }
	
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
	        public Nullable<long> TimeValue { get; set; }
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
	        public Nullable<long> Duration { get; set; }
	
	        /// <summary>
	        /// 是否开启请假证明
	        /// </summary>
	        [XmlElement("enable")]
	        public Nullable<bool> Enable { get; set; }
	
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

        #endregion
    }
}
