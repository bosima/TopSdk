using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCourseListResponse.
    /// </summary>
    public class OapiEduCourseListResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlElement("result")]
        public ListCourseResponseDomain Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ClassroomsDomain Data Structure.
/// </summary>
[Serializable]

public class ClassroomsDomain : TopObject
{
	        /// <summary>
	        /// 课堂交互信息
	        /// </summary>
	        [XmlElement("interact_info")]
	        public string InteractInfo { get; set; }
	
	        /// <summary>
	        /// 课堂唯一标识id
	        /// </summary>
	        [XmlElement("target_id")]
	        public string TargetId { get; set; }
}

	/// <summary>
/// CourseVODomain Data Structure.
/// </summary>
[Serializable]

public class CourseVODomain : TopObject
{
	        /// <summary>
	        /// 业务唯一键
	        /// </summary>
	        [XmlElement("biz_key")]
	        public string BizKey { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("classrooms")]
	        [XmlArrayItem("classrooms")]
	        public List<ClassroomsDomain> Classrooms { get; set; }
	
	        /// <summary>
	        /// 课程编码
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 创建者的组织CorpId
	        /// </summary>
	        [XmlElement("creator_corpid")]
	        public string CreatorCorpid { get; set; }
	
	        /// <summary>
	        /// 创建者的用户ID
	        /// </summary>
	        [XmlElement("creator_userid")]
	        public string CreatorUserid { get; set; }
	
	        /// <summary>
	        /// 创建者的用户名
	        /// </summary>
	        [XmlElement("creator_username")]
	        public string CreatorUsername { get; set; }
	
	        /// <summary>
	        /// 结束时间，Unix毫秒时间戳
	        /// </summary>
	        [XmlElement("end_time")]
	        public long EndTime { get; set; }
	
	        /// <summary>
	        /// 课程扩展信息
	        /// </summary>
	        [XmlElement("ext_info")]
	        public string ExtInfo { get; set; }
	
	        /// <summary>
	        /// 课程介绍
	        /// </summary>
	        [XmlElement("introduce")]
	        public string Introduce { get; set; }
	
	        /// <summary>
	        /// 课程名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 新版在线课堂
	        /// </summary>
	        [XmlElement("platform")]
	        public long Platform { get; set; }
	
	        /// <summary>
	        /// 开始时间，Unix毫秒时间戳
	        /// </summary>
	        [XmlElement("start_time")]
	        public long StartTime { get; set; }
	
	        /// <summary>
	        /// 课程状态 -1取消，0未开始，1进行中，2已结束
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 老的的组织CorpId
	        /// </summary>
	        [XmlElement("teacher_corpid")]
	        public string TeacherCorpid { get; set; }
	
	        /// <summary>
	        /// 老师的用户ID
	        /// </summary>
	        [XmlElement("teacher_userid")]
	        public string TeacherUserid { get; set; }
	
	        /// <summary>
	        /// 老师的用户名
	        /// </summary>
	        [XmlElement("teacher_username")]
	        public string TeacherUsername { get; set; }
}

	/// <summary>
/// ListCourseResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ListCourseResponseDomain : TopObject
{
	        /// <summary>
	        /// 是否还有更多数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("course_v_o")]
	        public List<CourseVODomain> List { get; set; }
	
	        /// <summary>
	        /// 表示下一次分页的游标，如果next_corsor为null或者has_more为false，表示没有更多的分页数据
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
	
	        /// <summary>
	        /// 数量总计100
	        /// </summary>
	        [XmlElement("total_count")]
	        public long TotalCount { get; set; }
}

    }
}
