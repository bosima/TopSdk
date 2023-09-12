using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGetAttendUpdateDataResponse.
    /// </summary>
    public class OapiAttendanceGetAttendUpdateDataResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlElement("result")]
        public AtCheckInfoForOpenVoDomain Result { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// AtAttendanceResultForOpenVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtAttendanceResultForOpenVoDomain : TopObject
{
	        /// <summary>
	        /// 打卡类型 上班还是下班
	        /// </summary>
	        [XmlElement("check_type")]
	        public string CheckType { get; set; }
	
	        /// <summary>
	        /// 班次id
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 考勤组id
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// 定位方法
	        /// </summary>
	        [XmlElement("location_method")]
	        public string LocationMethod { get; set; }
	
	        /// <summary>
	        /// 定位结果
	        /// </summary>
	        [XmlElement("location_result")]
	        public string LocationResult { get; set; }
	
	        /// <summary>
	        /// 外勤备注
	        /// </summary>
	        [XmlElement("outside_remark")]
	        public string OutsideRemark { get; set; }
	
	        /// <summary>
	        /// 标准打卡时间
	        /// </summary>
	        [XmlElement("plan_check_time")]
	        public string PlanCheckTime { get; set; }
	
	        /// <summary>
	        /// 排班id
	        /// </summary>
	        [XmlElement("plan_id")]
	        public long PlanId { get; set; }
	
	        /// <summary>
	        /// 审批单id
	        /// </summary>
	        [XmlElement("procInst_id")]
	        public string ProcInstId { get; set; }
	
	        /// <summary>
	        /// 打卡流水id
	        /// </summary>
	        [XmlElement("record_id")]
	        public long RecordId { get; set; }
	
	        /// <summary>
	        /// 打卡来源
	        /// </summary>
	        [XmlElement("source_type")]
	        public string SourceType { get; set; }
	
	        /// <summary>
	        /// 打卡的时间结果
	        /// </summary>
	        [XmlElement("time_result")]
	        public string TimeResult { get; set; }
	
	        /// <summary>
	        /// 用户打卡地址
	        /// </summary>
	        [XmlElement("user_address")]
	        public string UserAddress { get; set; }
	
	        /// <summary>
	        /// 用户打卡时间
	        /// </summary>
	        [XmlElement("user_check_time")]
	        public string UserCheckTime { get; set; }
}

	/// <summary>
/// AtApproveForOpenVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtApproveForOpenVoDomain : TopObject
{
	        /// <summary>
	        /// 审批单开始时间
	        /// </summary>
	        [XmlElement("begin_time")]
	        public string BeginTime { get; set; }
	
	        /// <summary>
	        /// 业务类型
	        /// </summary>
	        [XmlElement("biz_type")]
	        public long BizType { get; set; }
	
	        /// <summary>
	        /// 时长
	        /// </summary>
	        [XmlElement("duration")]
	        public string Duration { get; set; }
	
	        /// <summary>
	        /// 审批单的单位
	        /// </summary>
	        [XmlElement("duration_unit")]
	        public string DurationUnit { get; set; }
	
	        /// <summary>
	        /// 审批单结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 审批单审批完成时间
	        /// </summary>
	        [XmlElement("gmt_finished")]
	        public string GmtFinished { get; set; }
	
	        /// <summary>
	        /// 审批单id
	        /// </summary>
	        [XmlElement("procInst_id")]
	        public string ProcInstId { get; set; }
	
	        /// <summary>
	        /// 子类型
	        /// </summary>
	        [XmlElement("sub_type")]
	        public string SubType { get; set; }
	
	        /// <summary>
	        /// 审批单的tag
	        /// </summary>
	        [XmlElement("tag_name")]
	        public string TagName { get; set; }
}

	/// <summary>
/// AtAttendanceRecordForOpenVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtAttendanceRecordForOpenVoDomain : TopObject
{
	        /// <summary>
	        /// 基本定位精度
	        /// </summary>
	        [XmlElement("base_accuracy")]
	        public string BaseAccuracy { get; set; }
	
	        /// <summary>
	        /// 打卡基础地质
	        /// </summary>
	        [XmlElement("base_address")]
	        public string BaseAddress { get; set; }
	
	        /// <summary>
	        /// 流水id
	        /// </summary>
	        [XmlElement("record_id")]
	        public long RecordId { get; set; }
	
	        /// <summary>
	        /// 打卡来源
	        /// </summary>
	        [XmlElement("source_type")]
	        public string SourceType { get; set; }
	
	        /// <summary>
	        /// 用户定位精度
	        /// </summary>
	        [XmlElement("user_accuracy")]
	        public string UserAccuracy { get; set; }
	
	        /// <summary>
	        /// 用户打卡时间
	        /// </summary>
	        [XmlElement("user_check_time")]
	        public string UserCheckTime { get; set; }
	
	        /// <summary>
	        /// 打卡纬度
	        /// </summary>
	        [XmlElement("user_latitude")]
	        public string UserLatitude { get; set; }
	
	        /// <summary>
	        /// 打卡维度
	        /// </summary>
	        [XmlElement("user_longitude")]
	        public string UserLongitude { get; set; }
	
	        /// <summary>
	        /// mac地址
	        /// </summary>
	        [XmlElement("user_mac_addr")]
	        public string UserMacAddr { get; set; }
	
	        /// <summary>
	        /// wifi名称
	        /// </summary>
	        [XmlElement("user_ssid")]
	        public string UserSsid { get; set; }
	
	        /// <summary>
	        /// 是否匹配
	        /// </summary>
	        [XmlElement("valid_matched")]
	        public bool ValidMatched { get; set; }
}

	/// <summary>
/// AtCheckInfoForOpenVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtCheckInfoForOpenVoDomain : TopObject
{
	        /// <summary>
	        /// 审批单列表
	        /// </summary>
	        [XmlElement("approve_list")]
	        public AtApproveForOpenVoDomain ApproveList { get; set; }
	
	        /// <summary>
	        /// 打卡结果list
	        /// </summary>
	        [XmlElement("attendance_result_list")]
	        public AtAttendanceResultForOpenVoDomain AttendanceResultList { get; set; }
	
	        /// <summary>
	        /// 打卡流水list
	        /// </summary>
	        [XmlElement("check_record_list")]
	        public AtAttendanceRecordForOpenVoDomain CheckRecordList { get; set; }
	
	        /// <summary>
	        /// 公司id
	        /// </summary>
	        [XmlElement("corpId")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 查询日期
	        /// </summary>
	        [XmlElement("work_date")]
	        public string WorkDate { get; set; }
}

    }
}
