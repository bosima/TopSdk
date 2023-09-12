using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduGradeQueryResponse.
    /// </summary>
    public class OapiEduGradeQueryResponse : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// GradesDomain Data Structure.
/// </summary>
[Serializable]

public class GradesDomain : TopObject
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
	        /// 年级level
	        /// </summary>
	        [XmlElement("grade")]
	        public long Grade { get; set; }
	
	        /// <summary>
	        /// 年级名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 学段code
	        /// </summary>
	        [XmlElement("period_code")]
	        public string PeriodCode { get; set; }
	
	        /// <summary>
	        /// 学段id
	        /// </summary>
	        [XmlElement("super_id")]
	        public long SuperId { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 年级列表
	        /// </summary>
	        [XmlArray("grades")]
	        [XmlArrayItem("grades")]
	        public List<GradesDomain> Grades { get; set; }
}

    }
}
