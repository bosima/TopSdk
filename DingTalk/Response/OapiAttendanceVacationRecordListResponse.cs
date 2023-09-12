using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceVacationRecordListResponse.
    /// </summary>
    public class OapiAttendanceVacationRecordListResponse : DingTalkResponse
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
        /// 结果值
        /// </summary>
        [XmlElement("result")]
        public OapiLeaveRecordListVoDomain Result { get; set; }

        /// <summary>
        /// 是否正确访问
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OapiLeaveRecordVoDomain Data Structure.
/// </summary>
[Serializable]

public class OapiLeaveRecordVoDomain : TopObject
{
	        /// <summary>
	        /// 计算类型(add delete update 如果是请假则为null)
	        /// </summary>
	        [XmlElement("cal_type")]
	        public string CalType { get; set; }
	
	        /// <summary>
	        /// 额度有效期结束时间(毫秒级时间戳)
	        /// </summary>
	        [XmlElement("end_time")]
	        public long EndTime { get; set; }
	
	        /// <summary>
	        /// 假期类型唯一标识
	        /// </summary>
	        [XmlElement("leave_code")]
	        public string LeaveCode { get; set; }
	
	        /// <summary>
	        /// 原因
	        /// </summary>
	        [XmlElement("leave_reason")]
	        public string LeaveReason { get; set; }
	
	        /// <summary>
	        /// 假期记录类型(leave update其中一种 请假还是更新配额)
	        /// </summary>
	        [XmlElement("leave_record_type")]
	        public string LeaveRecordType { get; set; }
	
	        /// <summary>
	        /// 请假状态(请假申请 init 请假通过 success 请假被拒 refuse 请假撤销 abort 撤销已同意的请假单并通过 revoke其中一种)
	        /// </summary>
	        [XmlElement("leave_status")]
	        public string LeaveStatus { get; set; }
	
	        /// <summary>
	        /// 显示单位(day hour 其中一种按天、小时计算)
	        /// </summary>
	        [XmlElement("leave_view_unit")]
	        public string LeaveViewUnit { get; set; }
	
	        /// <summary>
	        /// 假期记录标识(扣减多条假期配额 该值不为空)
	        /// </summary>
	        [XmlElement("parent_record_id")]
	        public string ParentRecordId { get; set; }
	
	        /// <summary>
	        /// 假期额度唯一标识
	        /// </summary>
	        [XmlElement("quota_id")]
	        public string QuotaId { get; set; }
	
	        /// <summary>
	        /// 假期消费记录唯一标识
	        /// </summary>
	        [XmlElement("record_id")]
	        public string RecordId { get; set; }
	
	        /// <summary>
	        /// 单位以天计算的消费额度(假期类型按天计算该值不为空且按百分之一天折算 例如 100=1天)
	        /// </summary>
	        [XmlElement("record_num_per_day")]
	        public long RecordNumPerDay { get; set; }
	
	        /// <summary>
	        /// 单位以小时计算的消费额度(假期类型按小时计算该值不为空且按百分之一小时折算 例如 100=1小时)
	        /// </summary>
	        [XmlElement("record_num_per_hour")]
	        public long RecordNumPerHour { get; set; }
	
	        /// <summary>
	        /// 额度有效期开始时间(毫秒级时间戳)
	        /// </summary>
	        [XmlElement("start_time")]
	        public long StartTime { get; set; }
	
	        /// <summary>
	        /// 员工ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OapiLeaveRecordListVoDomain Data Structure.
/// </summary>
[Serializable]

public class OapiLeaveRecordListVoDomain : TopObject
{
	        /// <summary>
	        /// 是否存在更多记录
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 假期消费记录列表
	        /// </summary>
	        [XmlArray("leave_records")]
	        [XmlArrayItem("oapi_leave_record_vo")]
	        public List<OapiLeaveRecordVoDomain> LeaveRecords { get; set; }
}

    }
}
