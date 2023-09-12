using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAtsJobQueryResponse.
    /// </summary>
    public class OapiAtsJobQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 职位数据列表
        /// </summary>
        [XmlElement("result")]
        public AtsPageResultDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// JobSimpleVoDomain Data Structure.
/// </summary>
[Serializable]

public class JobSimpleVoDomain : TopObject
{
	        /// <summary>
	        /// true表示校招，false表示社招
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
	        /// 职位创建时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public string CreateTime { get; set; }
	
	        /// <summary>
	        /// 创建人userId
	        /// </summary>
	        [XmlElement("creator_user_id")]
	        public string CreatorUserId { get; set; }
	
	        /// <summary>
	        /// 职位地址 区/县
	        /// </summary>
	        [XmlElement("district")]
	        public string District { get; set; }
	
	        /// <summary>
	        /// 职位编码
	        /// </summary>
	        [XmlElement("job_code")]
	        public string JobCode { get; set; }
	
	        /// <summary>
	        /// 职位标识
	        /// </summary>
	        [XmlElement("job_id")]
	        public string JobId { get; set; }
	
	        /// <summary>
	        /// 职位类型：FULL-TIME:全职，PART-TIME:兼职，INTERNSHIP:实习，OTHER:其他
	        /// </summary>
	        [XmlElement("job_nature")]
	        public string JobNature { get; set; }
	
	        /// <summary>
	        /// 最高薪水，单位元
	        /// </summary>
	        [XmlElement("max_salary")]
	        public long MaxSalary { get; set; }
	
	        /// <summary>
	        /// 最低薪水，单位元
	        /// </summary>
	        [XmlElement("min_salary")]
	        public long MinSalary { get; set; }
	
	        /// <summary>
	        /// 职位更新时间
	        /// </summary>
	        [XmlElement("modified_time")]
	        public string ModifiedTime { get; set; }
	
	        /// <summary>
	        /// 职位名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 职位地址 省
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// 薪资月数
	        /// </summary>
	        [XmlElement("salary_month")]
	        public long SalaryMonth { get; set; }
	
	        /// <summary>
	        /// 薪资类型，HOUR:小时，DAY:天，WEEK:周，MONTH:月，BY_TIME:次
	        /// </summary>
	        [XmlElement("salary_period")]
	        public string SalaryPeriod { get; set; }
	
	        /// <summary>
	        /// 状态，1表示启用中，2表示关闭
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
}

	/// <summary>
/// AtsPageResultDomain Data Structure.
/// </summary>
[Serializable]

public class AtsPageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否还有数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 职位信息列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("job_simple_vo")]
	        public List<JobSimpleVoDomain> List { get; set; }
	
	        /// <summary>
	        /// 游标，下次分页请求使用
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public string NextCursor { get; set; }
}

    }
}
