using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAtsJobGetResponse.
    /// </summary>
    public class OapiAtsJobGetResponse : DingTalkResponse
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
        /// 职位结果
        /// </summary>
        [XmlElement("result")]
        public JobSimpleVODomain Result { get; set; }

	/// <summary>
/// JobAddressVODomain Data Structure.
/// </summary>
[Serializable]

public class JobAddressVODomain : TopObject
{
	        /// <summary>
	        /// 地点详情
	        /// </summary>
	        [XmlElement("detail")]
	        public string Detail { get; set; }
	
	        /// <summary>
	        /// 经度
	        /// </summary>
	        [XmlElement("latitude")]
	        public string Latitude { get; set; }
	
	        /// <summary>
	        /// 纬度
	        /// </summary>
	        [XmlElement("longitude")]
	        public string Longitude { get; set; }
	
	        /// <summary>
	        /// 地点名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// TopJobPartTimeExtDataVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopJobPartTimeExtDataVoDomain : TopObject
{
	        /// <summary>
	        /// 兼职联系方式
	        /// </summary>
	        [XmlElement("contact_number")]
	        public string ContactNumber { get; set; }
	
	        /// <summary>
	        /// 薪资计算周期 HOUR:按小时，DAY:按天，WEEK:按周，MONTH:按月，BY_TIME:按次
	        /// </summary>
	        [XmlElement("salary_period")]
	        public string SalaryPeriod { get; set; }
	
	        /// <summary>
	        /// 薪资结算周期 DAY:日结，WEEK:周结，MONTH:月结，ONE_TIME:一次性结清，OTHER:其他
	        /// </summary>
	        [XmlElement("settle_type")]
	        public string SettleType { get; set; }
	
	        /// <summary>
	        /// 是否指定工作日期，如果指定，则填充work_start_date，work_end_date
	        /// </summary>
	        [XmlElement("specify_work_date")]
	        public bool SpecifyWorkDate { get; set; }
	
	        /// <summary>
	        /// 是否指定工作时间，如果指定，则填充work_begin_time_min, work_end_time_min
	        /// </summary>
	        [XmlElement("specify_work_time")]
	        public bool SpecifyWorkTime { get; set; }
	
	        /// <summary>
	        /// 工作开始时间，单位分钟，从0点0分开始,如8:30为510
	        /// </summary>
	        [XmlElement("work_begin_time_min")]
	        public long WorkBeginTimeMin { get; set; }
	
	        /// <summary>
	        /// 工作日期类型 WORKDAY:工作日，WEEKEND:周末，HOLIDAY:节假日，NOT_WORKDAY:非工作日，包括周末和假期,OTHER:其他
	        /// </summary>
	        [XmlElement("work_date_type")]
	        public string WorkDateType { get; set; }
	
	        /// <summary>
	        /// 工作结束日期
	        /// </summary>
	        [XmlElement("work_end_date")]
	        public string WorkEndDate { get; set; }
	
	        /// <summary>
	        /// 工作结束时间，单位分钟，从0点0分，如10:00值为600
	        /// </summary>
	        [XmlElement("work_end_time_min")]
	        public long WorkEndTimeMin { get; set; }
	
	        /// <summary>
	        /// 工作开始日期
	        /// </summary>
	        [XmlElement("work_start_date")]
	        public string WorkStartDate { get; set; }
}

	/// <summary>
/// JobSimpleVODomain Data Structure.
/// </summary>
[Serializable]

public class JobSimpleVODomain : TopObject
{
	        /// <summary>
	        /// 职位地址详情
	        /// </summary>
	        [XmlElement("address")]
	        public JobAddressVODomain Address { get; set; }
	
	        /// <summary>
	        /// true :校招，false：社招
	        /// </summary>
	        [XmlElement("campus")]
	        public bool Campus { get; set; }
	
	        /// <summary>
	        /// 职位分类
	        /// </summary>
	        [XmlElement("category")]
	        public string Category { get; set; }
	
	        /// <summary>
	        /// 职位地址 市
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 职位描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 职位地址 区/县
	        /// </summary>
	        [XmlElement("district")]
	        public string District { get; set; }
	
	        /// <summary>
	        /// 招募人数
	        /// </summary>
	        [XmlElement("head_count")]
	        public long HeadCount { get; set; }
	
	        /// <summary>
	        /// 职位编码
	        /// </summary>
	        [XmlElement("job_code")]
	        public string JobCode { get; set; }
	
	        /// <summary>
	        /// 职位唯一标识
	        /// </summary>
	        [XmlElement("job_id")]
	        public string JobId { get; set; }
	
	        /// <summary>
	        /// 职位类型：FULL-TIME:全职，PART-TIME:兼职，INTERNSHIP:实习，OTHER:其他
	        /// </summary>
	        [XmlElement("job_nature")]
	        public string JobNature { get; set; }
	
	        /// <summary>
	        /// 职位部门id
	        /// </summary>
	        [XmlElement("main_dept_id")]
	        public long MainDeptId { get; set; }
	
	        /// <summary>
	        /// 最高工作年限
	        /// </summary>
	        [XmlElement("max_job_experience")]
	        public long MaxJobExperience { get; set; }
	
	        /// <summary>
	        /// 最高薪水，单位元
	        /// </summary>
	        [XmlElement("max_salary")]
	        public long MaxSalary { get; set; }
	
	        /// <summary>
	        /// 最低工作年限
	        /// </summary>
	        [XmlElement("min_job_experience")]
	        public long MinJobExperience { get; set; }
	
	        /// <summary>
	        /// 最低薪水，单位元
	        /// </summary>
	        [XmlElement("min_salary")]
	        public long MinSalary { get; set; }
	
	        /// <summary>
	        /// 职位名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 兼职字段
	        /// </summary>
	        [XmlElement("part_time_data")]
	        public TopJobPartTimeExtDataVoDomain PartTimeData { get; set; }
	
	        /// <summary>
	        /// 职位地址 升
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// 1小学 2初中 3高中 4中专 5大专 6本科 7硕士 8 博士 9其他
	        /// </summary>
	        [XmlElement("required_edu")]
	        public long RequiredEdu { get; set; }
	
	        /// <summary>
	        /// 薪资月数
	        /// </summary>
	        [XmlElement("salary_month")]
	        public long SalaryMonth { get; set; }
	
	        /// <summary>
	        /// 是否薪资面议
	        /// </summary>
	        [XmlElement("salary_negotiable")]
	        public bool SalaryNegotiable { get; set; }
	
	        /// <summary>
	        /// 薪资类型，HOUR:小时，DAY:天，WEEK:周，MONTH:月，BY_TIME:次
	        /// </summary>
	        [XmlElement("salary_period")]
	        public string SalaryPeriod { get; set; }
	
	        /// <summary>
	        /// 职位标签
	        /// </summary>
	        [XmlArray("tags")]
	        [XmlArrayItem("string")]
	        public List<string> Tags { get; set; }
}

    }
}
