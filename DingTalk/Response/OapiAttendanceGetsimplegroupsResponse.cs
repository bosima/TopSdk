using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGetsimplegroupsResponse.
    /// </summary>
    public class OapiAttendanceGetsimplegroupsResponse : DingTalkResponse
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
        public AtGroupListForTopVoDomain Result { get; set; }

	/// <summary>
/// AtTimeVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtTimeVoDomain : TopObject
{
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("check_time")]
	        public string CheckTime { get; set; }
}

	/// <summary>
/// ClassSettingVoDomain Data Structure.
/// </summary>
[Serializable]

public class ClassSettingVoDomain : TopObject
{
	        /// <summary>
	        /// 旷工迟到时长,单位分钟
	        /// </summary>
	        [XmlElement("absenteeism_late_minutes")]
	        public long AbsenteeismLateMinutes { get; set; }
	
	        /// <summary>
	        /// 考勤组班次id
	        /// </summary>
	        [XmlElement("class_setting_id")]
	        public long ClassSettingId { get; set; }
	
	        /// <summary>
	        /// Y表示下班不强制打卡,N表示下班强制打卡
	        /// </summary>
	        [XmlElement("is_off_duty_free_check")]
	        public string IsOffDutyFreeCheck { get; set; }
	
	        /// <summary>
	        /// 允许迟到时长，单位分钟
	        /// </summary>
	        [XmlElement("permit_late_minutes")]
	        public long PermitLateMinutes { get; set; }
	
	        /// <summary>
	        /// 休息开始时间，只有一个时间段的班次有
	        /// </summary>
	        [XmlElement("rest_begin_time")]
	        public AtTimeVoDomain RestBeginTime { get; set; }
	
	        /// <summary>
	        /// 休息结束时间，只有一个时间段的班次有
	        /// </summary>
	        [XmlElement("rest_end_time")]
	        public AtTimeVoDomain RestEndTime { get; set; }
	
	        /// <summary>
	        /// 严重迟到时长,单位分钟
	        /// </summary>
	        [XmlElement("serious_late_minutes")]
	        public long SeriousLateMinutes { get; set; }
	
	        /// <summary>
	        /// 工作时长，单位分钟，-1表示关闭该功能
	        /// </summary>
	        [XmlElement("work_time_minutes")]
	        public long WorkTimeMinutes { get; set; }
}

	/// <summary>
/// SetionTimeVODomain Data Structure.
/// </summary>
[Serializable]

public class SetionTimeVODomain : TopObject
{
	        /// <summary>
	        /// 打卡时间跨度
	        /// </summary>
	        [XmlElement("across")]
	        public long Across { get; set; }
	
	        /// <summary>
	        /// 打卡时间
	        /// </summary>
	        [XmlElement("check_time")]
	        public string CheckTime { get; set; }
	
	        /// <summary>
	        /// 打卡类型枚举（Onduty和OffDuty）
	        /// </summary>
	        [XmlElement("check_type")]
	        public string CheckType { get; set; }
}

	/// <summary>
/// AtSectionVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtSectionVoDomain : TopObject
{
	        /// <summary>
	        /// 时间段列表
	        /// </summary>
	        [XmlArray("times")]
	        [XmlArrayItem("setion_time_v_o")]
	        public List<SetionTimeVODomain> Times { get; set; }
}

	/// <summary>
/// AtClassVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtClassVoDomain : TopObject
{
	        /// <summary>
	        /// 考勤班次id
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 考勤班次名称
	        /// </summary>
	        [XmlElement("class_name")]
	        public string ClassName { get; set; }
	
	        /// <summary>
	        /// 班次打卡时间段,最多
	        /// </summary>
	        [XmlArray("sections")]
	        [XmlArrayItem("at_section_vo")]
	        public List<AtSectionVoDomain> Sections { get; set; }
	
	        /// <summary>
	        /// 考勤组班次配置
	        /// </summary>
	        [XmlElement("setting")]
	        public ClassSettingVoDomain Setting { get; set; }
}

	/// <summary>
/// AtGroupForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtGroupForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 一周的班次时间展示列表。["周一、二 班次A:09:00-18:00", "周六、周日 休息"]
	        /// </summary>
	        [XmlArray("classes_list")]
	        [XmlArrayItem("string")]
	        public List<string> ClassesList { get; set; }
	
	        /// <summary>
	        /// 默认班次id
	        /// </summary>
	        [XmlElement("default_class_id")]
	        public long DefaultClassId { get; set; }
	
	        /// <summary>
	        /// 考勤组添加的部门Id列表
	        /// </summary>
	        [XmlArray("dept_ids")]
	        [XmlArrayItem("number")]
	        public List<long> DeptIds { get; set; }
	
	        /// <summary>
	        /// 关联的部门
	        /// </summary>
	        [XmlArray("dept_name_list")]
	        [XmlArrayItem("string")]
	        public List<string> DeptNameList { get; set; }
	
	        /// <summary>
	        /// 休息日打卡需审批
	        /// </summary>
	        [XmlElement("disable_check_when_rest")]
	        public bool DisableCheckWhenRest { get; set; }
	
	        /// <summary>
	        /// 未排班时是否禁止员工打卡
	        /// </summary>
	        [XmlElement("disable_check_without_schedule")]
	        public bool DisableCheckWithoutSchedule { get; set; }
	
	        /// <summary>
	        /// 未排班时允许员工选择班次打卡
	        /// </summary>
	        [XmlElement("enable_emp_select_class")]
	        public bool EnableEmpSelectClass { get; set; }
	
	        /// <summary>
	        /// 自由工时考勤组考勤开始时间与当天0点偏移分钟数（如：240表示4:00）
	        /// </summary>
	        [XmlElement("freecheck_day_start_min_offset")]
	        public long FreecheckDayStartMinOffset { get; set; }
	
	        /// <summary>
	        /// 自由工时考勤组工作日（1表示周一，0表示周日）
	        /// </summary>
	        [XmlArray("freecheck_work_days")]
	        [XmlArrayItem("number")]
	        public List<long> FreecheckWorkDays { get; set; }
	
	        /// <summary>
	        /// 考勤组id
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// 考勤组名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
	
	        /// <summary>
	        /// 是否默认考勤组
	        /// </summary>
	        [XmlElement("is_default")]
	        public bool IsDefault { get; set; }
	
	        /// <summary>
	        /// 考勤组负责人
	        /// </summary>
	        [XmlArray("manager_list")]
	        [XmlArrayItem("string")]
	        public List<string> ManagerList { get; set; }
	
	        /// <summary>
	        /// 成员人数
	        /// </summary>
	        [XmlElement("member_count")]
	        public long MemberCount { get; set; }
	
	        /// <summary>
	        /// 考勤组主负责人
	        /// </summary>
	        [XmlElement("owner_user_id")]
	        public string OwnerUserId { get; set; }
	
	        /// <summary>
	        /// 考勤组对应的考勤班次列表
	        /// </summary>
	        [XmlArray("selected_class")]
	        [XmlArrayItem("at_class_vo")]
	        public List<AtClassVoDomain> SelectedClass { get; set; }
	
	        /// <summary>
	        /// 考勤类型，FIXED为固定排班，TURN为轮班排班，NONE为无班次
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 考勤组里按照人添加的人
	        /// </summary>
	        [XmlArray("user_ids")]
	        [XmlArrayItem("string")]
	        public List<string> UserIds { get; set; }
	
	        /// <summary>
	        /// 固定班次的工作日班次
	        /// </summary>
	        [XmlArray("work_day_list")]
	        [XmlArrayItem("string")]
	        public List<string> WorkDayList { get; set; }
}

	/// <summary>
/// AtGroupListForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtGroupListForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 考勤组列表
	        /// </summary>
	        [XmlArray("groups")]
	        [XmlArrayItem("at_group_for_top_vo")]
	        public List<AtGroupForTopVoDomain> Groups { get; set; }
	
	        /// <summary>
	        /// 分页用，表示是否还有下一页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
}

    }
}
