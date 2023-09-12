using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduStudentListResponse.
    /// </summary>
    public class OapiEduStudentListResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlElement("result")]
        public PageResultDomain Result { get; set; }

        /// <summary>
        /// 成功状态
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

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
	
	        /// <summary>
	        /// 学生ID
	        /// </summary>
	        [XmlElement("student_userid")]
	        public string StudentUserid { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否有下一页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("student_respone")]
	        public List<StudentResponeDomain> List { get; set; }
	
	        /// <summary>
	        /// 下一页游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
