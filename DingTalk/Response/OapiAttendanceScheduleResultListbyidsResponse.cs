using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceScheduleResultListbyidsResponse.
    /// </summary>
    public class OapiAttendanceScheduleResultListbyidsResponse : DingTalkResponse
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
        [XmlArrayItem("top_schedule_result_vo")]
        public List<TopScheduleResultVoDomain> Result { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TopScheduleResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopScheduleResultVoDomain : TopObject
{
	        /// <summary>
	        /// 迟到早退线
	        /// </summary>
	        [XmlElement("base_check_time")]
	        public string BaseCheckTime { get; set; }
	
	        /// <summary>
	        /// 考勤类型，上班/下班
	        /// </summary>
	        [XmlElement("check_type")]
	        public string CheckType { get; set; }
	
	        /// <summary>
	        /// 公司id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 更新时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
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
	        /// 是否合法
	        /// </summary>
	        [XmlElement("is_legal")]
	        public string IsLegal { get; set; }
	
	        /// <summary>
	        /// 位置结果
	        /// </summary>
	        [XmlElement("location_result")]
	        public string LocationResult { get; set; }
	
	        /// <summary>
	        /// 计划打卡时间
	        /// </summary>
	        [XmlElement("plan_check_time")]
	        public string PlanCheckTime { get; set; }
	
	        /// <summary>
	        /// 打卡记录
	        /// </summary>
	        [XmlElement("record_id")]
	        public long RecordId { get; set; }
	
	        /// <summary>
	        /// 排班id
	        /// </summary>
	        [XmlElement("schedule_id")]
	        public long ScheduleId { get; set; }
	
	        /// <summary>
	        /// 时间结果
	        /// </summary>
	        [XmlElement("time_result")]
	        public string TimeResult { get; set; }
	
	        /// <summary>
	        /// 打卡时间
	        /// </summary>
	        [XmlElement("user_check_time")]
	        public string UserCheckTime { get; set; }
	
	        /// <summary>
	        /// 用户userId
	        /// </summary>
	        [XmlElement("user_id")]
	        public string UserId { get; set; }
	
	        /// <summary>
	        /// 工作天
	        /// </summary>
	        [XmlElement("work_date")]
	        public string WorkDate { get; set; }
}

    }
}
