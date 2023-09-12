using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.student.create
    /// </summary>
    public class OapiEduStudentCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduStudentCreateResponse>
    {
        /// <summary>
        /// 业务唯一id
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 班级id
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        /// <summary>
        /// 学生手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 学生名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 钉钉企业管理员
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        public string StudentNo { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.student.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_id", this.BizId);
            parameters.Add("class_id", this.ClassId);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("name", this.Name);
            parameters.Add("operator", this.Operator);
            parameters.Add("student_no", this.StudentNo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("class_id", this.ClassId);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("operator", this.Operator);
        }

        #endregion
    }
}
