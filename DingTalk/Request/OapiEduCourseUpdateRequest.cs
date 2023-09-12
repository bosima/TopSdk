using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.update
    /// </summary>
    public class OapiEduCourseUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseUpdateResponse>
    {
        /// <summary>
        /// 课程唯一编码
        /// </summary>
        public string CourseCode { get; set; }

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
            return "dingtalk.oapi.edu.course.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("course_code", this.CourseCode);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("introduce", this.Introduce);
            parameters.Add("name", this.Name);
            parameters.Add("op_userid", this.OpUserid);
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
            RequestValidator.ValidateRequired("course_code", this.CourseCode);
            RequestValidator.ValidateMaxLength("introduce", this.Introduce, 120);
            RequestValidator.ValidateMaxLength("name", this.Name, 64);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
        }

        #endregion
    }
}
