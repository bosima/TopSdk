using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceShiftQueryResponse.
    /// </summary>
    public class OapiAttendanceShiftQueryResponse : DingTalkResponse
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
        /// 班次
        /// </summary>
        [XmlElement("result")]
        public TopShiftVoDomain Result { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TopShiftSettingVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopShiftSettingVoDomain : TopObject
{
	        /// <summary>
	        /// 该班次对应的出勤天数
	        /// </summary>
	        [XmlElement("attend_days")]
	        public string AttendDays { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 固定时长弹性班次设置的工作时长
	        /// </summary>
	        [XmlElement("demand_work_time_minutes")]
	        public long DemandWorkTimeMinutes { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 班次变更时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 删除标记
	        /// </summary>
	        [XmlElement("is_deleted")]
	        public string IsDeleted { get; set; }
	
	        /// <summary>
	        /// 是否是弹性班次
	        /// </summary>
	        [XmlElement("is_flexible")]
	        public bool IsFlexible { get; set; }
	
	        /// <summary>
	        /// 班次id
	        /// </summary>
	        [XmlElement("shift_id")]
	        public long ShiftId { get; set; }
	
	        /// <summary>
	        /// 工作时长，单位分钟，-1表示关闭该功能
	        /// </summary>
	        [XmlElement("work_time_minutes")]
	        public long WorkTimeMinutes { get; set; }
}

	/// <summary>
/// TopPunchVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopPunchVoDomain : TopObject
{
	        /// <summary>
	        /// 旷工早退/迟到的时长
	        /// </summary>
	        [XmlElement("absenteeism_late_minutes")]
	        public string AbsenteeismLateMinutes { get; set; }
	
	        /// <summary>
	        /// 是否跨天
	        /// </summary>
	        [XmlElement("across")]
	        public long Across { get; set; }
	
	        /// <summary>
	        /// 允许的最早提前打卡时间，分钟为单位
	        /// </summary>
	        [XmlElement("begin_min")]
	        public long BeginMin { get; set; }
	
	        /// <summary>
	        /// 打卡时间
	        /// </summary>
	        [XmlElement("check_time")]
	        public string CheckTime { get; set; }
	
	        /// <summary>
	        /// 打卡类型
	        /// </summary>
	        [XmlElement("check_type")]
	        public string CheckType { get; set; }
	
	        /// <summary>
	        /// 允许的最晚延后打卡时间，分钟为单位
	        /// </summary>
	        [XmlElement("end_min")]
	        public long EndMin { get; set; }
	
	        /// <summary>
	        /// 当前卡点允许弹性调整范围
	        /// </summary>
	        [XmlArray("flex_minutes")]
	        [XmlArrayItem("number")]
	        public List<long> FlexMinutes { get; set; }
	
	        /// <summary>
	        /// 是否免打卡
	        /// </summary>
	        [XmlElement("free_check")]
	        public bool FreeCheck { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 允许早退/迟到的时长
	        /// </summary>
	        [XmlElement("permit_minutes")]
	        public long PermitMinutes { get; set; }
	
	        /// <summary>
	        /// 严重早退/迟到的时长
	        /// </summary>
	        [XmlElement("serious_late_minutes")]
	        public string SeriousLateMinutes { get; set; }
}

	/// <summary>
/// TopRestVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopRestVoDomain : TopObject
{
	        /// <summary>
	        /// 是否跨天
	        /// </summary>
	        [XmlElement("across")]
	        public long Across { get; set; }
	
	        /// <summary>
	        /// 休息时间
	        /// </summary>
	        [XmlElement("check_time")]
	        public string CheckTime { get; set; }
	
	        /// <summary>
	        /// 休息类型
	        /// </summary>
	        [XmlElement("check_type")]
	        public string CheckType { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
}

	/// <summary>
/// TopSectionVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopSectionVoDomain : TopObject
{
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 卡点
	        /// </summary>
	        [XmlArray("punches")]
	        [XmlArrayItem("top_punch_vo")]
	        public List<TopPunchVoDomain> Punches { get; set; }
	
	        /// <summary>
	        /// 休息段
	        /// </summary>
	        [XmlArray("rests")]
	        [XmlArrayItem("top_rest_vo")]
	        public List<TopRestVoDomain> Rests { get; set; }
	
	        /// <summary>
	        /// 工作时长，单位分钟
	        /// </summary>
	        [XmlElement("work_time_minutes")]
	        public long WorkTimeMinutes { get; set; }
}

	/// <summary>
/// TopShiftVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopShiftVoDomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 班次负责人
	        /// </summary>
	        [XmlElement("owner")]
	        public string Owner { get; set; }
	
	        /// <summary>
	        /// 卡段
	        /// </summary>
	        [XmlArray("sections")]
	        [XmlArrayItem("top_section_vo")]
	        public List<TopSectionVoDomain> Sections { get; set; }
	
	        /// <summary>
	        /// 班组id
	        /// </summary>
	        [XmlElement("shift_group_id")]
	        public long ShiftGroupId { get; set; }
	
	        /// <summary>
	        /// 班次组名称
	        /// </summary>
	        [XmlElement("shift_group_name")]
	        public string ShiftGroupName { get; set; }
	
	        /// <summary>
	        /// 班次设置
	        /// </summary>
	        [XmlElement("shift_setting")]
	        public TopShiftSettingVoDomain ShiftSetting { get; set; }
}

    }
}
