using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.shift.add
    /// </summary>
    public class OapiAttendanceShiftAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceShiftAddResponse>
    {
        /// <summary>
        /// 操作人
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 班次
        /// </summary>
        public string Shift { get; set; }

        public TopAtClassVoDomain Shift_ { set { this.Shift = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.shift.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("op_user_id", this.OpUserId);
            parameters.Add("shift", this.Shift);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
            RequestValidator.ValidateRequired("shift", this.Shift);
        }

	/// <summary>
/// TopAtTimeVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopAtTimeVoDomain : TopObject
{
	        /// <summary>
	        /// 是否跨天
	        /// </summary>
	        [XmlElement("across")]
	        public Nullable<long> Across { get; set; }
	
	        /// <summary>
	        /// 允许的最早提前打卡时间，分钟为单位
	        /// </summary>
	        [XmlElement("begin_min")]
	        public Nullable<long> BeginMin { get; set; }
	
	        /// <summary>
	        /// check时间
	        /// </summary>
	        [XmlElement("check_time")]
	        public Nullable<DateTime> CheckTime { get; set; }
	
	        /// <summary>
	        /// 类型(OnDuty上班，OffDuty下班)
	        /// </summary>
	        [XmlElement("check_type")]
	        public string CheckType { get; set; }
	
	        /// <summary>
	        /// 允许的最玩打卡时间，分钟为单位（-1表示不限制）
	        /// </summary>
	        [XmlElement("end_min")]
	        public Nullable<long> EndMin { get; set; }
	
	        /// <summary>
	        /// 当前卡点允许弹性调整范围
	        /// </summary>
	        [XmlArray("flex_minutes")]
	        [XmlArrayItem("number")]
	        public List<string> FlexMinutes { get; set; }
	
	        /// <summary>
	        /// 是否免打卡
	        /// </summary>
	        [XmlElement("free_check")]
	        public Nullable<bool> FreeCheck { get; set; }
}

	/// <summary>
/// TopAtSectionVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopAtSectionVoDomain : TopObject
{
	        /// <summary>
	        /// times
	        /// </summary>
	        [XmlArray("times")]
	        [XmlArrayItem("top_at_time_vo")]
	        public List<TopAtTimeVoDomain> Times { get; set; }
}

	/// <summary>
/// TopAtClassSettingVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopAtClassSettingVoDomain : TopObject
{
	        /// <summary>
	        /// 旷工迟到分钟数
	        /// </summary>
	        [XmlElement("absenteeism_late_minutes")]
	        public Nullable<long> AbsenteeismLateMinutes { get; set; }
	
	        /// <summary>
	        /// 该班次对应的出勤天数
	        /// </summary>
	        [XmlElement("attend_days")]
	        public string AttendDays { get; set; }
	
	        /// <summary>
	        /// 班次id
	        /// </summary>
	        [XmlElement("class_id")]
	        public Nullable<long> ClassId { get; set; }
	
	        /// <summary>
	        /// corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 固定时长弹性班次设置的工作时长
	        /// </summary>
	        [XmlElement("demand_work_time_minutes")]
	        public Nullable<long> DemandWorkTimeMinutes { get; set; }
	
	        /// <summary>
	        /// 班次设置扩展字段（非临时班次无需填写）
	        /// </summary>
	        [XmlElement("extras")]
	        public string Extras { get; set; }
	
	        /// <summary>
	        /// 是否删除
	        /// </summary>
	        [XmlElement("is_deleted")]
	        public string IsDeleted { get; set; }
	
	        /// <summary>
	        /// 是否弹性
	        /// </summary>
	        [XmlElement("is_flexible")]
	        public Nullable<bool> IsFlexible { get; set; }
	
	        /// <summary>
	        /// 休息开始
	        /// </summary>
	        [XmlElement("rest_begin_time")]
	        public TopAtTimeVoDomain RestBeginTime { get; set; }
	
	        /// <summary>
	        /// 休息结束
	        /// </summary>
	        [XmlElement("rest_end_time")]
	        public TopAtTimeVoDomain RestEndTime { get; set; }
	
	        /// <summary>
	        /// 严重迟到分钟数
	        /// </summary>
	        [XmlElement("serious_late_minutes")]
	        public Nullable<long> SeriousLateMinutes { get; set; }
	
	        /// <summary>
	        /// 班次tags（非临时班次无需填写）
	        /// </summary>
	        [XmlElement("tags")]
	        public string Tags { get; set; }
}

	/// <summary>
/// TopAtClassVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopAtClassVoDomain : TopObject
{
	        /// <summary>
	        /// 班次组名
	        /// </summary>
	        [XmlElement("class_group_name")]
	        public string ClassGroupName { get; set; }
	
	        /// <summary>
	        /// corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 班次id
	        /// </summary>
	        [XmlElement("id")]
	        public Nullable<long> Id { get; set; }
	
	        /// <summary>
	        /// 班次名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 班次owner
	        /// </summary>
	        [XmlElement("owner")]
	        public string Owner { get; set; }
	
	        /// <summary>
	        /// sections
	        /// </summary>
	        [XmlArray("sections")]
	        [XmlArrayItem("top_at_section_vo")]
	        public List<TopAtSectionVoDomain> Sections { get; set; }
	
	        /// <summary>
	        /// 高级排班绑定服务id（非临时班次无需填写）
	        /// </summary>
	        [XmlElement("service_id")]
	        public Nullable<long> ServiceId { get; set; }
	
	        /// <summary>
	        /// 设置
	        /// </summary>
	        [XmlElement("setting")]
	        public TopAtClassSettingVoDomain Setting { get; set; }
}

        #endregion
    }
}
