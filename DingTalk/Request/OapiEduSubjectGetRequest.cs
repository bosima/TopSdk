using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.subject.get
    /// </summary>
    public class OapiEduSubjectGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduSubjectGetResponse>
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public string OperatorUserid { get; set; }

        /// <summary>
        /// 学段编码
        /// </summary>
        public string PeriodCode { get; set; }

        /// <summary>
        /// 学科编码
        /// </summary>
        public string SubjectCode { get; set; }

        /// <summary>
        /// 学科名称
        /// </summary>
        public string SubjectName { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.subject.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("operator_userid", this.OperatorUserid);
            parameters.Add("period_code", this.PeriodCode);
            parameters.Add("subject_code", this.SubjectCode);
            parameters.Add("subject_name", this.SubjectName);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("operator_userid", this.OperatorUserid);
            RequestValidator.ValidateRequired("period_code", this.PeriodCode);
        }

        #endregion
    }
}
