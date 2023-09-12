using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.replay
    /// </summary>
    public class OapiEduCourseReplayRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseReplayResponse>
    {
        /// <summary>
        /// 需要回放的课程编码
        /// </summary>
        public string CourseCode { get; set; }

        /// <summary>
        /// 操作用户id
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 指定一段的历史回放编码
        /// </summary>
        public string TargetId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.course.replay";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("course_code", this.CourseCode);
            parameters.Add("op_user_id", this.OpUserId);
            parameters.Add("target_id", this.TargetId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("course_code", this.CourseCode);
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
        }

        #endregion
    }
}
