using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.homework.student.report.submit
    /// </summary>
    public class OapiEduHomeworkStudentReportSubmitRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduHomeworkStudentReportSubmitResponse>
    {
        /// <summary>
        /// 扩展属性
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// 业务编码
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        /// <summary>
        /// 作业ID
        /// </summary>
        public Nullable<long> HwId { get; set; }

        /// <summary>
        /// 作业报告
        /// </summary>
        public string HwReport { get; set; }

        /// <summary>
        /// 作业结果
        /// </summary>
        public string HwResult { get; set; }

        /// <summary>
        /// 学生ID
        /// </summary>
        public string StudentId { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StudentName { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.homework.student.report.submit";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attributes", this.Attributes);
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("class_id", this.ClassId);
            parameters.Add("hw_id", this.HwId);
            parameters.Add("hw_report", this.HwReport);
            parameters.Add("hw_result", this.HwResult);
            parameters.Add("student_id", this.StudentId);
            parameters.Add("student_name", this.StudentName);
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
            RequestValidator.ValidateRequired("student_name", this.StudentName);
        }

        #endregion
    }
}
