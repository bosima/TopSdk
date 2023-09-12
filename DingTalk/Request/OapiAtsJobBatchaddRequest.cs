using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.job.batchadd
    /// </summary>
    public class OapiAtsJobBatchaddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsJobBatchaddResponse>
    {
        /// <summary>
        /// 招聘业务标识
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 职位列表，单次最多20个
        /// </summary>
        public string Jobs { get; set; }

        public List<AtsAddJobParamDomain> Jobs_ { set { this.Jobs = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 操作人员工标识
        /// </summary>
        public string OpUserId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.job.batchadd";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("jobs", this.Jobs);
            parameters.Add("op_user_id", this.OpUserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("jobs", this.Jobs);
            RequestValidator.ValidateObjectMaxListSize("jobs", this.Jobs, 999);
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
        }

	/// <summary>
/// JobFullTimeExtDataVoDomain Data Structure.
/// </summary>
[Serializable]

public class JobFullTimeExtDataVoDomain : TopObject
{
	        /// <summary>
	        /// 薪资发放月数
	        /// </summary>
	        [XmlElement("salary_month")]
	        public Nullable<long> SalaryMonth { get; set; }
}

	/// <summary>
/// JobExtDataVoDomain Data Structure.
/// </summary>
[Serializable]

public class JobExtDataVoDomain : TopObject
{
	        /// <summary>
	        /// 职位来源渠道
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 全职扩展数据
	        /// </summary>
	        [XmlElement("full_time_ext_data")]
	        public JobFullTimeExtDataVoDomain FullTimeExtData { get; set; }
	
	        /// <summary>
	        /// 招募人数
	        /// </summary>
	        [XmlElement("head_count")]
	        public Nullable<long> HeadCount { get; set; }
}

	/// <summary>
/// JobAddressVoDomain Data Structure.
/// </summary>
[Serializable]

public class JobAddressVoDomain : TopObject
{
	        /// <summary>
	        /// 位置详情
	        /// </summary>
	        [XmlElement("detail")]
	        public string Detail { get; set; }
	
	        /// <summary>
	        /// 位置名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// AtsAddJobParamDomain Data Structure.
/// </summary>
[Serializable]

public class AtsAddJobParamDomain : TopObject
{
	        /// <summary>
	        /// 工作地点
	        /// </summary>
	        [XmlElement("address")]
	        public JobAddressVoDomain Address { get; set; }
	
	        /// <summary>
	        /// 是否校招
	        /// </summary>
	        [XmlElement("campus")]
	        public Nullable<bool> Campus { get; set; }
	
	        /// <summary>
	        /// 城市编码
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 操作人员工标识
	        /// </summary>
	        [XmlElement("creator_user_id")]
	        public string CreatorUserId { get; set; }
	
	        /// <summary>
	        /// 职位描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 区县编码
	        /// </summary>
	        [XmlElement("district")]
	        public string District { get; set; }
	
	        /// <summary>
	        /// 扩展数据
	        /// </summary>
	        [XmlElement("ext_data")]
	        public JobExtDataVoDomain ExtData { get; set; }
	
	        /// <summary>
	        /// 职位性质，FULL-TIME：全职，PART-TIME：兼职，INTERNSHIP：实习，OTHER：其他
	        /// </summary>
	        [XmlElement("job_nature")]
	        public string JobNature { get; set; }
	
	        /// <summary>
	        /// 最低月薪，单位：元
	        /// </summary>
	        [XmlElement("max_salary")]
	        public Nullable<long> MaxSalary { get; set; }
	
	        /// <summary>
	        /// 最高月薪，单位：元
	        /// </summary>
	        [XmlElement("min_salary")]
	        public Nullable<long> MinSalary { get; set; }
	
	        /// <summary>
	        /// 职位名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 职位负责人的员工标识列表
	        /// </summary>
	        [XmlArray("owner_user_ids")]
	        [XmlArrayItem("string")]
	        public List<string> OwnerUserIds { get; set; }
	
	        /// <summary>
	        /// 省域编码
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// 学历要求，1小学 2初中 3高中  4中专 5大专 6本科  7硕士 8 博士 9其他
	        /// </summary>
	        [XmlElement("required_edu")]
	        public Nullable<long> RequiredEdu { get; set; }
}

        #endregion
    }
}
