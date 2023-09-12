using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceVacationQuotaListResponse.
    /// </summary>
    public class OapiAttendanceVacationQuotaListResponse : DingTalkResponse
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
        public OapiLeaveQuotaUserListVoDomain Result { get; set; }

        /// <summary>
        /// 是否正确访问
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// LeavequotasDomain Data Structure.
/// </summary>
[Serializable]

public class LeavequotasDomain : TopObject
{
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
	        /// 额度所对应的周期
	        /// </summary>
	        [XmlElement("quota_cycle")]
	        public string QuotaCycle { get; set; }
	
	        /// <summary>
	        /// 配额唯一标记
	        /// </summary>
	        [XmlElement("quota_id")]
	        public string QuotaId { get; set; }
	
	        /// <summary>
	        /// 单位以小时计算的额度总数(假期类型按小时计算该值不为空且按百分之一小时折算 例如 1000=10小时)
	        /// </summary>
	        [XmlElement("quota_num_per_day")]
	        public long QuotaNumPerDay { get; set; }
	
	        /// <summary>
	        /// 单位以天计算的额度总数(假期类型按天计算该值不为空且按百分之一天折算 例如 1000=10天)
	        /// </summary>
	        [XmlElement("quota_num_per_hour")]
	        public long QuotaNumPerHour { get; set; }
	
	        /// <summary>
	        /// 额度有效期开始时间(毫秒级时间戳)
	        /// </summary>
	        [XmlElement("start_time")]
	        public long StartTime { get; set; }
	
	        /// <summary>
	        /// 单位以天计算的使用额度(假期类型按天计算该值不为空且按百分之一天折算 例如 100=1天)
	        /// </summary>
	        [XmlElement("used_num_per_day")]
	        public long UsedNumPerDay { get; set; }
	
	        /// <summary>
	        /// 单位以小时计算的使用额度(假期类型按小时计算该值不为空且按百分之一小时折算 例如 100=1小时)
	        /// </summary>
	        [XmlElement("used_num_per_hour")]
	        public long UsedNumPerHour { get; set; }
	
	        /// <summary>
	        /// 员工ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OapiLeaveQuotaUserListVoDomain Data Structure.
/// </summary>
[Serializable]

public class OapiLeaveQuotaUserListVoDomain : TopObject
{
	        /// <summary>
	        /// 是否存在更多记录
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 假期余额列表
	        /// </summary>
	        [XmlArray("leave_quotas")]
	        [XmlArrayItem("leavequotas")]
	        public List<LeavequotasDomain> LeaveQuotas { get; set; }
}

    }
}
