using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.vacation.quota.update
    /// </summary>
    public class OapiAttendanceVacationQuotaUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceVacationQuotaUpdateResponse>
    {
        /// <summary>
        /// 待更新的假期余额记录
        /// </summary>
        public string LeaveQuotas { get; set; }

        public List<LeaveQuotasDomain> LeaveQuotas_ { set { this.LeaveQuotas = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 操作者ID
        /// </summary>
        public string OpUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.vacation.quota.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("leave_quotas", this.LeaveQuotas);
            parameters.Add("op_userid", this.OpUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("leave_quotas", this.LeaveQuotas);
            RequestValidator.ValidateObjectMaxListSize("leave_quotas", this.LeaveQuotas, 100);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
        }

	/// <summary>
/// LeaveQuotasDomain Data Structure.
/// </summary>
[Serializable]

public class LeaveQuotasDomain : TopObject
{
	        /// <summary>
	        /// 额度有效期结束时间(毫秒级时间戳)
	        /// </summary>
	        [XmlElement("end_time")]
	        public Nullable<long> EndTime { get; set; }
	
	        /// <summary>
	        /// 假期类型唯一标识
	        /// </summary>
	        [XmlElement("leave_code")]
	        public string LeaveCode { get; set; }
	
	        /// <summary>
	        /// 额度所对应的周期(除了假期类型为调休的时候可以为空之外 其他情况均不能为空 且格式必须满足"yyyy")
	        /// </summary>
	        [XmlElement("quota_cycle")]
	        public string QuotaCycle { get; set; }
	
	        /// <summary>
	        /// 单位以天计算的额度总数(假期类型按天计算该值不为空且按百分之一天折算 例如 100=1天)
	        /// </summary>
	        [XmlElement("quota_num_per_day")]
	        public Nullable<long> QuotaNumPerDay { get; set; }
	
	        /// <summary>
	        /// 单位以小时计算的额度总数(假期类型按小时计算该值不为空且按百分之一小时折算 例如 100=1小时)
	        /// </summary>
	        [XmlElement("quota_num_per_hour")]
	        public Nullable<long> QuotaNumPerHour { get; set; }
	
	        /// <summary>
	        /// 操作原因
	        /// </summary>
	        [XmlElement("reason")]
	        public string Reason { get; set; }
	
	        /// <summary>
	        /// 额度有效期开始时间(毫秒级时间戳)
	        /// </summary>
	        [XmlElement("start_time")]
	        public Nullable<long> StartTime { get; set; }
	
	        /// <summary>
	        /// 员工ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
