using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduPeriodCreateResponse.
    /// </summary>
    public class OapiEduPeriodCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果值
        /// </summary>
        [XmlElement("result")]
        public OpenPeriodCreateResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// EduGradeDoDomain Data Structure.
/// </summary>
[Serializable]

public class EduGradeDoDomain : TopObject
{
	        /// <summary>
	        /// 校区id
	        /// </summary>
	        [XmlElement("campus_id")]
	        public long CampusId { get; set; }
	
	        /// <summary>
	        /// 年级id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 年级等级
	        /// </summary>
	        [XmlElement("grade")]
	        public long Grade { get; set; }
	
	        /// <summary>
	        /// 年级名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 学段id
	        /// </summary>
	        [XmlElement("super_id")]
	        public long SuperId { get; set; }
}

	/// <summary>
/// OpenPeriodCreateResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenPeriodCreateResponseDomain : TopObject
{
	        /// <summary>
	        /// 学段id
	        /// </summary>
	        [XmlElement("deptId")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 年级id，有可能会空列表，需要通过读接口查询
	        /// </summary>
	        [XmlArray("grades")]
	        [XmlArrayItem("edu_grade_do")]
	        public List<EduGradeDoDomain> Grades { get; set; }
}

    }
}
