using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduHomeworkStudentCommentListResponse.
    /// </summary>
    public class OapiEduHomeworkStudentCommentListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误编码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("open_hw_comment_response")]
        public List<OpenHwCommentResponseDomain> Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenHwCommentResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenHwCommentResponseDomain : TopObject
{
	        /// <summary>
	        /// 扩展属性
	        /// </summary>
	        [XmlElement("attributes")]
	        public string Attributes { get; set; }
	
	        /// <summary>
	        /// 评论内容
	        /// </summary>
	        [XmlElement("comment")]
	        public string Comment { get; set; }
	
	        /// <summary>
	        /// 评论ID
	        /// </summary>
	        [XmlElement("comment_id")]
	        public long CommentId { get; set; }
	
	        /// <summary>
	        /// 评论时间
	        /// </summary>
	        [XmlElement("comment_time")]
	        public string CommentTime { get; set; }
	
	        /// <summary>
	        /// 视频
	        /// </summary>
	        [XmlElement("media")]
	        public string Media { get; set; }
	
	        /// <summary>
	        /// 图片
	        /// </summary>
	        [XmlElement("photo")]
	        public string Photo { get; set; }
	
	        /// <summary>
	        /// 学生ID
	        /// </summary>
	        [XmlElement("student_id")]
	        public string StudentId { get; set; }
	
	        /// <summary>
	        /// 学生姓名
	        /// </summary>
	        [XmlElement("student_name")]
	        public string StudentName { get; set; }
	
	        /// <summary>
	        /// 老师ID
	        /// </summary>
	        [XmlElement("teacher_id")]
	        public string TeacherId { get; set; }
	
	        /// <summary>
	        /// 老师姓名
	        /// </summary>
	        [XmlElement("teacher_name")]
	        public string TeacherName { get; set; }
	
	        /// <summary>
	        /// 音频
	        /// </summary>
	        [XmlElement("video")]
	        public string Video { get; set; }
}

    }
}
