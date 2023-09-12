using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.batchcreate
    /// </summary>
    public class OapiEduCourseBatchcreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseBatchcreateResponse>
    {
        /// <summary>
        /// course_infos
        /// </summary>
        public string CourseInfos { get; set; }

        public List<CourseInfoDomain> CourseInfos_ { set { this.CourseInfos = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 当前用户ID
        /// </summary>
        public string OpUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.course.batchcreate";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("course_infos", this.CourseInfos);
            parameters.Add("op_userid", this.OpUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("course_infos", this.CourseInfos);
            RequestValidator.ValidateObjectMaxListSize("course_infos", this.CourseInfos, 999);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
        }

	/// <summary>
/// CourseOptionDomain Data Structure.
/// </summary>
[Serializable]

public class CourseOptionDomain : TopObject
{
	        /// <summary>
	        /// 课堂模式：1/6/12（支持多少人上台）
	        /// </summary>
	        [XmlElement("online_mode")]
	        public string OnlineMode { get; set; }
	
	        /// <summary>
	        /// 使用的平台：1（在线课堂）、2（在线课堂Pro）
	        /// </summary>
	        [XmlElement("platform")]
	        public string Platform { get; set; }
	
	        /// <summary>
	        /// 是否录制老师头像
	        /// </summary>
	        [XmlElement("record_avatar")]
	        public string RecordAvatar { get; set; }
}

	/// <summary>
/// CourseInfoDomain Data Structure.
/// </summary>
[Serializable]

public class CourseInfoDomain : TopObject
{
	        /// <summary>
	        /// 业务唯一键，用于保证课程的唯一性，防止重复创建
	        /// </summary>
	        [XmlElement("biz_key")]
	        public string BizKey { get; set; }
	
	        /// <summary>
	        /// 课程的结束时间，Unix毫秒时间戳
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
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
	        /// 课程选项信息
	        /// </summary>
	        [XmlElement("option")]
	        public CourseOptionDomain Option { get; set; }
	
	        /// <summary>
	        /// 课程的开始时间，Unix毫秒时间戳
	        /// </summary>
	        [XmlElement("start_time")]
	        public string StartTime { get; set; }
	
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

        #endregion
    }
}
