using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceScheduleListbydayResponse.
    /// </summary>
    public class OapiAttendanceScheduleListbydayResponse : DingTalkResponse
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
	        /// 审批类型
	        /// </summary>
	        [XmlElement("approve_biz_type")]
	        public long ApproveBizType { get; set; }
	
	        /// <summary>
	        /// 审批单id
	        /// </summary>
	        [XmlElement("approve_id")]
	        public long ApproveId { get; set; }
	
	        /// <summary>
	        /// 审批单标签名
	        /// </summary>
	        [XmlElement("approve_tag_name")]
	        public string ApproveTagName { get; set; }
	
	        /// <summary>
	        /// 审批类型
	        /// </summary>
	        [XmlElement("approve_type")]
	        public string ApproveType { get; set; }
	
	        /// <summary>
	        /// 迟到早退线
	        /// </summary>
	        [XmlElement("base_check_time")]
	        public string BaseCheckTime { get; set; }
	
	        /// <summary>
	        /// 开始打卡时间
	        /// </summary>
	        [XmlElement("check_begin_time")]
	        public string CheckBeginTime { get; set; }
	
	        /// <summary>
	        /// 打卡时间
	        /// </summary>
	        [XmlElement("check_date_time")]
	        public string CheckDateTime { get; set; }
	
	        /// <summary>
	        /// 结束打卡时间
	        /// </summary>
	        [XmlElement("check_end_time")]
	        public string CheckEndTime { get; set; }
	
	        /// <summary>
	        /// 打卡状态
	        /// </summary>
	        [XmlElement("check_status")]
	        public string CheckStatus { get; set; }
	
	        /// <summary>
	        /// 考勤类型，上班/下班
	        /// </summary>
	        [XmlElement("check_type")]
	        public string CheckType { get; set; }
	
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
	        /// 班次version
	        /// </summary>
	        [XmlElement("class_setting_id")]
	        public long ClassSettingId { get; set; }
	
	        /// <summary>
	        /// 公司id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 扩展字段
	        /// </summary>
	        [XmlElement("features")]
	        public string Features { get; set; }
	
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
	        /// 是否休息
	        /// </summary>
	        [XmlElement("is_rest")]
	        public string IsRest { get; set; }
	
	        /// <summary>
	        /// 计划打卡时间
	        /// </summary>
	        [XmlElement("plan_check_time")]
	        public string PlanCheckTime { get; set; }
	
	        /// <summary>
	        /// 根据弹性、打卡结果等综合计算的卡点，与个人月历页保持一致
	        /// </summary>
	        [XmlElement("real_plan_time")]
	        public string RealPlanTime { get; set; }
	
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
