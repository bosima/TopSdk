using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGroupQueryResponse.
    /// </summary>
    public class OapiAttendanceGroupQueryResponse : DingTalkResponse
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
        [XmlElement("result")]
        public TopSimpleGroupVODomain Result { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TopCycleScheduleItemVODomain Data Structure.
/// </summary>
[Serializable]

public class TopCycleScheduleItemVODomain : TopObject
{
	        /// <summary>
	        /// 班次id
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 班次名称
	        /// </summary>
	        [XmlElement("class_name")]
	        public string ClassName { get; set; }
	
	        /// <summary>
	        /// 是否有效
	        /// </summary>
	        [XmlElement("is_valid")]
	        public string IsValid { get; set; }
}

	/// <summary>
/// TopCycleScheduleVODomain Data Structure.
/// </summary>
[Serializable]

public class TopCycleScheduleVODomain : TopObject
{
	        /// <summary>
	        /// 排班周期名称
	        /// </summary>
	        [XmlElement("cycle_name")]
	        public string CycleName { get; set; }
	
	        /// <summary>
	        /// 是否删除
	        /// </summary>
	        [XmlElement("is_deleted")]
	        public string IsDeleted { get; set; }
	
	        /// <summary>
	        /// 是否有效
	        /// </summary>
	        [XmlElement("is_valid")]
	        public string IsValid { get; set; }
	
	        /// <summary>
	        /// 每天的班次设置
	        /// </summary>
	        [XmlArray("item_list")]
	        [XmlArrayItem("top_cycle_schedule_item_v_o")]
	        public List<TopCycleScheduleItemVODomain> ItemList { get; set; }
}

	/// <summary>
/// TopSimpleGroupVODomain Data Structure.
/// </summary>
[Serializable]

public class TopSimpleGroupVODomain : TopObject
{
	        /// <summary>
	        /// 考勤地址
	        /// </summary>
	        [XmlArray("address_list")]
	        [XmlArrayItem("string")]
	        public List<string> AddressList { get; set; }
	
	        /// <summary>
	        /// 排班周期设置
	        /// </summary>
	        [XmlArray("cycle_schedules")]
	        [XmlArrayItem("top_cycle_schedule_v_o")]
	        public List<TopCycleScheduleVODomain> CycleSchedules { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 考勤组管理员
	        /// </summary>
	        [XmlElement("manager_list")]
	        public string ManagerList { get; set; }
	
	        /// <summary>
	        /// 人员人数
	        /// </summary>
	        [XmlElement("member_count")]
	        public long MemberCount { get; set; }
	
	        /// <summary>
	        /// 名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 考勤组主负责人 id
	        /// </summary>
	        [XmlElement("owner_user_id")]
	        public string OwnerUserId { get; set; }
	
	        /// <summary>
	        /// 考勤组关联的班次列表
	        /// </summary>
	        [XmlArray("shift_ids")]
	        [XmlArrayItem("number")]
	        public List<long> ShiftIds { get; set; }
	
	        /// <summary>
	        /// 固定值，轮班制
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 跳转链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
	
	        /// <summary>
	        /// wifi名称
	        /// </summary>
	        [XmlArray("wifis")]
	        [XmlArrayItem("string")]
	        public List<string> Wifis { get; set; }
	
	        /// <summary>
	        /// 工作日
	        /// </summary>
	        [XmlArray("work_day_list")]
	        [XmlArrayItem("number")]
	        public List<long> WorkDayList { get; set; }
}

    }
}
