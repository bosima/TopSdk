using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.end
    /// </summary>
    public class OapiEduCourseEndRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseEndResponse>
    {
        /// <summary>
        /// 需要结束的课程编码
        /// </summary>
        public string CourseCode { get; set; }

        /// <summary>
        /// 操作用户id
        /// </summary>
        public string OpUserId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.course.end";
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
