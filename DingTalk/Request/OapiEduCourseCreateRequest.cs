using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.create
    /// </summary>
    public class OapiEduCourseCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseCreateResponse>
    {
        /// <summary>
        /// 业务唯一键，用于保证课程的唯一性，防止重复创建
        /// </summary>
        public string BizKey { get; set; }

        /// <summary>
        /// 课程的结束时间，Unix毫秒时间戳
        /// </summary>
        public Nullable<long> EndTime { get; set; }

        /// <summary>
        /// 课程介绍
        /// </summary>
        public string Introduce { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 当前用户ID
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 课程选项信息
        /// </summary>
        public string Option { get; set; }

        public CreateCourseOptionDomain Option_ { set { this.Option = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 课程的开始时间，Unix毫秒时间戳
        /// </summary>
        public Nullable<long> StartTime { get; set; }

        /// <summary>
        /// 老师的组织CorpId
        /// </summary>
        public string TeacherCorpid { get; set; }

        /// <summary>
        /// 老师的用户ID
        /// </summary>
        public string TeacherUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.course.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_key", this.BizKey);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("introduce", this.Introduce);
            parameters.Add("name", this.Name);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("option", this.Option);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("teacher_corpid", this.TeacherCorpid);
            parameters.Add("teacher_userid", this.TeacherUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_key", this.BizKey);
            RequestValidator.ValidateMaxLength("biz_key", this.BizKey, 64);
            RequestValidator.ValidateRequired("introduce", this.Introduce);
            RequestValidator.ValidateMaxLength("introduce", this.Introduce, 120);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 64);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("teacher_corpid", this.TeacherCorpid);
            RequestValidator.ValidateRequired("teacher_userid", this.TeacherUserid);
        }

	/// <summary>
/// CreateCourseOptionDomain Data Structure.
/// </summary>
[Serializable]

public class CreateCourseOptionDomain : TopObject
{
	        /// <summary>
	        /// 课堂模式：1/6/12（支持多少人上台）
	        /// </summary>
	        [XmlElement("onlineMode")]
	        public string OnlineMode { get; set; }
	
	        /// <summary>
	        /// 使用的平台：1（在线课堂）、2（在线课堂Pro）
	        /// </summary>
	        [XmlElement("platform")]
	        public string Platform { get; set; }
	
	        /// <summary>
	        /// 是否录制老师头像
	        /// </summary>
	        [XmlElement("recordAvatar")]
	        public Nullable<bool> RecordAvatar { get; set; }
}

        #endregion
    }
}
