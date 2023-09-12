using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.homework.student.mark.tag
    /// </summary>
    public class OapiEduHomeworkStudentMarkTagRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduHomeworkStudentMarkTagResponse>
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
        /// 学生userid
        /// </summary>
        public string StudentId { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// 作业标记：优秀、良好、差
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 老师userid
        /// </summary>
        public string TeacherId { get; set; }

        /// <summary>
        /// 文本内容
        /// </summary>
        public string Text { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.homework.student.mark.tag";
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
            parameters.Add("student_name", this.StudentName);
            parameters.Add("tag", this.Tag);
            parameters.Add("teacher_id", this.TeacherId);
            parameters.Add("text", this.Text);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
