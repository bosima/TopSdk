using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.homework.student.comment.list
    /// </summary>
    public class OapiEduHomeworkStudentCommentListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduHomeworkStudentCommentListResponse>
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 班级ID
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        /// <summary>
        /// 作业ID
        /// </summary>
        public Nullable<long> HwId { get; set; }

        /// <summary>
        /// 学生ID
        /// </summary>
        public string StudentId { get; set; }

        /// <summary>
        /// 老师userID
        /// </summary>
        public string TeacherUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.homework.student.comment.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("class_id", this.ClassId);
            parameters.Add("hw_id", this.HwId);
            parameters.Add("student_id", this.StudentId);
            parameters.Add("teacher_userid", this.TeacherUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("class_id", this.ClassId);
            RequestValidator.ValidateRequired("hw_id", this.HwId);
            RequestValidator.ValidateRequired("student_id", this.StudentId);
            RequestValidator.ValidateRequired("teacher_userid", this.TeacherUserid);
        }

        #endregion
    }
}
