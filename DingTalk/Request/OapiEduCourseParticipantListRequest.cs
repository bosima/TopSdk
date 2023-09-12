using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.participant.list
    /// </summary>
    public class OapiEduCourseParticipantListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseParticipantListResponse>
    {
        /// <summary>
        /// 课程编码
        /// </summary>
        public string CourseCode { get; set; }

        /// <summary>
        /// 表示分页游标，从0开始
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 当前操作人的用户ID
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 表示分页大小
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.course.participant.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("course_code", this.CourseCode);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("course_code", this.CourseCode);
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateMinValue("cursor", this.Cursor, 0);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 100);
            RequestValidator.ValidateMinValue("size", this.Size, 1);
        }

        #endregion
    }
}
