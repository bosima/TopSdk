using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduStudentGetResponse.
    /// </summary>
    public class OapiEduStudentGetResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlElement("result")]
        public StudentResponeDomain Result { get; set; }

        /// <summary>
        /// 成功状态
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// GuardianResponeDomain Data Structure.
/// </summary>
[Serializable]

public class GuardianResponeDomain : TopObject
{
	        /// <summary>
	        /// 家长ID
	        /// </summary>
	        [XmlElement("guardian_userid")]
	        public string GuardianUserid { get; set; }
	
	        /// <summary>
	        /// 别名
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 关系
	        /// </summary>
	        [XmlElement("relation")]
	        public string Relation { get; set; }
}

	/// <summary>
/// StudentResponeDomain Data Structure.
/// </summary>
[Serializable]

public class StudentResponeDomain : TopObject
{
	        /// <summary>
	        /// 校区ID
	        /// </summary>
	        [XmlElement("campus_id")]
	        public long CampusId { get; set; }
	
	        /// <summary>
	        /// 班级ID
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 年级ID
	        /// </summary>
	        [XmlElement("grade_id")]
	        public long GradeId { get; set; }
	
	        /// <summary>
	        /// guardians
	        /// </summary>
	        [XmlArray("guardians")]
	        [XmlArrayItem("guardian_respone")]
	        public List<GuardianResponeDomain> Guardians { get; set; }
	
	        /// <summary>
	        /// 名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 学段ID
	        /// </summary>
	        [XmlElement("period_id")]
	        public long PeriodId { get; set; }
	
	        /// <summary>
	        /// 学号
	        /// </summary>
	        [XmlElement("student_no")]
	        public string StudentNo { get; set; }
}

    }
}
