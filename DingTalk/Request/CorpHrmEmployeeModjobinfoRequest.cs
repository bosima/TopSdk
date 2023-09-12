using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.hrm.employee.modjobinfo
    /// </summary>
    public class CorpHrmEmployeeModjobinfoRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpHrmEmployeeModjobinfoResponse>
    {
        /// <summary>
        /// 员工信息对象，被操作人userid是必填，其他信息选填，填写则更新
        /// </summary>
        public string HrmApiJobModel { get; set; }

        public HrmApiJobModelDomain HrmApiJobModel_ { set { this.HrmApiJobModel = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 操作人userid，必须是拥有被操作人操作权限的管理员userid
        /// </summary>
        public string OpUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.hrm.employee.modjobinfo";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("hrm_api_job_model", this.HrmApiJobModel);
            parameters.Add("op_userid", this.OpUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("hrm_api_job_model", this.HrmApiJobModel);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
        }

	/// <summary>
/// HrmApiJobModelDomain Data Structure.
/// </summary>
[Serializable]

public class HrmApiJobModelDomain : TopObject
{
	        /// <summary>
	        /// 生日日期
	        /// </summary>
	        [XmlElement("birth_time")]
	        public Nullable<DateTime> BirthTime { get; set; }
	
	        /// <summary>
	        /// 入职日期
	        /// </summary>
	        [XmlElement("confirm_join_time")]
	        public Nullable<DateTime> ConfirmJoinTime { get; set; }
	
	        /// <summary>
	        /// 员工状态（2:试用，3:正式）
	        /// </summary>
	        [XmlElement("employee_status")]
	        public Nullable<long> EmployeeStatus { get; set; }
	
	        /// <summary>
	        /// 员工类型（1:全职，2:兼职，3:实习，4:劳务派遣，5:退休返聘，6:劳务外包）
	        /// </summary>
	        [XmlElement("employee_type")]
	        public Nullable<long> EmployeeType { get; set; }
	
	        /// <summary>
	        /// 首次参加工作时间
	        /// </summary>
	        [XmlElement("join_working_time")]
	        public Nullable<DateTime> JoinWorkingTime { get; set; }
	
	        /// <summary>
	        /// 试用期（1:无试用期，2:1个月，3:2个月，4:3个月，5:4个月，6:5个月，7:6个月，8:其他）
	        /// </summary>
	        [XmlElement("probation_period_type")]
	        public Nullable<long> ProbationPeriodType { get; set; }
	
	        /// <summary>
	        /// 转正时间
	        /// </summary>
	        [XmlElement("regular_time")]
	        public Nullable<DateTime> RegularTime { get; set; }
	
	        /// <summary>
	        /// 被操作人userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
