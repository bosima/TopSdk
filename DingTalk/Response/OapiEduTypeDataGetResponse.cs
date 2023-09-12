using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduTypeDataGetResponse.
    /// </summary>
    public class OapiEduTypeDataGetResponse : DingTalkResponse
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
        /// 结果合集
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("open_edu_school_type_statistical_data_response")]
        public List<OpenEduSchoolTypeStatisticalDataResponseDomain> Result { get; set; }

        /// <summary>
        /// 成功偶然失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenEduSchoolTypeStatisticalDataResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduSchoolTypeStatisticalDataResponseDomain : TopObject
{
	        /// <summary>
	        /// 数字化教师数量
	        /// </summary>
	        [XmlElement("auth_teacher_cnt_std")]
	        public string AuthTeacherCntStd { get; set; }
	
	        /// <summary>
	        /// 班级数量
	        /// </summary>
	        [XmlElement("class_cnt_std")]
	        public string ClassCntStd { get; set; }
	
	        /// <summary>
	        /// 学校id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 多家长监管学生数
	        /// </summary>
	        [XmlElement("multi_patriarch_student_cnt")]
	        public string MultiPatriarchStudentCnt { get; set; }
	
	        /// <summary>
	        /// 多家长监管学生比率
	        /// </summary>
	        [XmlElement("multi_patriarch_student_ratio")]
	        public string MultiPatriarchStudentRatio { get; set; }
	
	        /// <summary>
	        /// 无家长监管学生数
	        /// </summary>
	        [XmlElement("none_patriarch_student_cnt")]
	        public string NonePatriarchStudentCnt { get; set; }
	
	        /// <summary>
	        /// 无家长监管学生比率
	        /// </summary>
	        [XmlElement("none_patriarch_student_ratio")]
	        public string NonePatriarchStudentRatio { get; set; }
	
	        /// <summary>
	        /// 家长数量
	        /// </summary>
	        [XmlElement("patriarch_cnt_std")]
	        public string PatriarchCntStd { get; set; }
	
	        /// <summary>
	        /// 学校数量
	        /// </summary>
	        [XmlElement("school_cnt_std")]
	        public string SchoolCntStd { get; set; }
	
	        /// <summary>
	        /// 学校类型
	        /// </summary>
	        [XmlElement("school_type")]
	        public string SchoolType { get; set; }
	
	        /// <summary>
	        /// 单家长监管学生数
	        /// </summary>
	        [XmlElement("single_patriarch_student_cnt")]
	        public string SinglePatriarchStudentCnt { get; set; }
	
	        /// <summary>
	        /// 单家长监管学生比率
	        /// </summary>
	        [XmlElement("single_patriarch_student_ratio")]
	        public string SinglePatriarchStudentRatio { get; set; }
	
	        /// <summary>
	        /// 统计日期
	        /// </summary>
	        [XmlElement("stat_date")]
	        public string StatDate { get; set; }
	
	        /// <summary>
	        /// 学生数量
	        /// </summary>
	        [XmlElement("student_cnt_std")]
	        public string StudentCntStd { get; set; }
	
	        /// <summary>
	        /// 教师数量
	        /// </summary>
	        [XmlElement("teacher_cnt_std")]
	        public string TeacherCntStd { get; set; }
	
	        /// <summary>
	        /// 双家长监管学生数
	        /// </summary>
	        [XmlElement("two_patriarch_student_cnt")]
	        public string TwoPatriarchStudentCnt { get; set; }
	
	        /// <summary>
	        /// 双家长监管学生比率
	        /// </summary>
	        [XmlElement("two_patriarch_student_ratio")]
	        public string TwoPatriarchStudentRatio { get; set; }
}

    }
}
