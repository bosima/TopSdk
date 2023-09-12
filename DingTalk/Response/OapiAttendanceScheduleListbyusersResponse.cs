using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceScheduleListbyusersResponse.
    /// </summary>
    public class OapiAttendanceScheduleListbyusersResponse : DingTalkResponse
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
        /// demo
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("top_schedule_vo")]
        public List<TopScheduleVoDomain> Result { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TopScheduleVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopScheduleVoDomain : TopObject
{
	        /// <summary>
	        /// 审批单id
	        /// </summary>
	        [XmlElement("approve_id")]
	        public long ApproveId { get; set; }
	
	        /// <summary>
	        /// 考勤类型，上班/下班
	        /// </summary>
	        [XmlElement("check_type")]
	        public string CheckType { get; set; }
	
	        /// <summary>
	        /// 考勤组id
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 是否休息
	        /// </summary>
	        [XmlElement("is_rest")]
	        public string IsRest { get; set; }
	
	        /// <summary>
	        /// 加班规则设置id
	        /// </summary>
	        [XmlElement("overtime_setting_id")]
	        public long OvertimeSettingId { get; set; }
	
	        /// <summary>
	        /// 计划打卡时间
	        /// </summary>
	        [XmlElement("plan_check_time")]
	        public string PlanCheckTime { get; set; }
	
	        /// <summary>
	        /// 班次版本
	        /// </summary>
	        [XmlElement("shift_id")]
	        public long ShiftId { get; set; }
	
	        /// <summary>
	        /// 班次id
	        /// </summary>
	        [XmlElement("shift_version")]
	        public long ShiftVersion { get; set; }
	
	        /// <summary>
	        /// 用户userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 工作天
	        /// </summary>
	        [XmlElement("work_date")]
	        public string WorkDate { get; set; }
}

    }
}
