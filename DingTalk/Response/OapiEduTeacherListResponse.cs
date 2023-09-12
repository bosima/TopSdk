using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduTeacherListResponse.
    /// </summary>
    public class OapiEduTeacherListResponse : DingTalkResponse
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
        [XmlArray("result")]
        [XmlArrayItem("teacher_respone")]
        public List<TeacherResponeDomain> Result { get; set; }

        /// <summary>
        /// 成功状态
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TeacherResponeDomain Data Structure.
/// </summary>
[Serializable]

public class TeacherResponeDomain : TopObject
{
	        /// <summary>
	        /// 校区ID
	        /// </summary>
	        [XmlElement("campus_id")]
	        public long CampusId { get; set; }
	
	        /// <summary>
	        /// 年级ID
	        /// </summary>
	        [XmlElement("grade_id")]
	        public long GradeId { get; set; }
	
	        /// <summary>
	        /// 是否为班主任，1是，0不是
	        /// </summary>
	        [XmlElement("is_adviser")]
	        public long IsAdviser { get; set; }
	
	        /// <summary>
	        /// 学段ID
	        /// </summary>
	        [XmlElement("period_id")]
	        public long PeriodId { get; set; }
	
	        /// <summary>
	        /// 名称
	        /// </summary>
	        [XmlElement("teacher_name")]
	        public string TeacherName { get; set; }
	
	        /// <summary>
	        /// 老师ID
	        /// </summary>
	        [XmlElement("teacher_userid")]
	        public string TeacherUserid { get; set; }
}

    }
}
