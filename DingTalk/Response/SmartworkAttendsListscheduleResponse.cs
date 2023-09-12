using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// SmartworkAttendsListscheduleResponse.
    /// </summary>
    public class SmartworkAttendsListscheduleResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// AtScheduleForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtScheduleForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 审批id,结果集中没有的话表示没有审批单
	        /// </summary>
	        [XmlElement("approve_id")]
	        public long ApproveId { get; set; }
	
	        /// <summary>
	        /// 打卡类型，Onduty表示上班打卡，OffDuty表示下班打卡
	        /// </summary>
	        [XmlElement("check_type")]
	        public string CheckType { get; set; }
	
	        /// <summary>
	        /// 考勤班次id
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 班次配置id，结果集中没有的话表示使用全局班次配置
	        /// </summary>
	        [XmlElement("class_setting_id")]
	        public long ClassSettingId { get; set; }
	
	        /// <summary>
	        /// 考勤组id
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// 打卡时间
	        /// </summary>
	        [XmlElement("plan_check_time")]
	        public string PlanCheckTime { get; set; }
	
	        /// <summary>
	        /// 排班id
	        /// </summary>
	        [XmlElement("plan_id")]
	        public long PlanId { get; set; }
	
	        /// <summary>
	        /// userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// AtScheduleListForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtScheduleListForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 分页用，表示是否还有下一页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 排班列表
	        /// </summary>
	        [XmlArray("schedules")]
	        [XmlArrayItem("at_schedule_for_top_vo")]
	        public List<AtScheduleForTopVoDomain> Schedules { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlElement("result")]
	        public AtScheduleListForTopVoDomain Result { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
