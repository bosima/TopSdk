using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCourseGetResponse.
    /// </summary>
    public class OapiEduCourseGetResponse : DingTalkResponse
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
        public CourseDomain Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// CourseDomain Data Structure.
/// </summary>
[Serializable]

public class CourseDomain : TopObject
{
	        /// <summary>
	        /// 业务唯一键
	        /// </summary>
	        [XmlElement("biz_key")]
	        public string BizKey { get; set; }
	
	        /// <summary>
	        /// 课程编码
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 课程结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public long EndTime { get; set; }
	
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
	        /// 课程开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public long StartTime { get; set; }
	
	        /// <summary>
	        /// 老师的组织CorpId
	        /// </summary>
	        [XmlElement("teacher_corpid")]
	        public string TeacherCorpid { get; set; }
	
	        /// <summary>
	        /// 老师的用户ID
	        /// </summary>
	        [XmlElement("teacher_userid")]
	        public string TeacherUserid { get; set; }
}

    }
}
