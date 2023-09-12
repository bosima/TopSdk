using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.hire.bizflow.start
    /// </summary>
    public class OapiHireBizflowStartRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiHireBizflowStartResponse>
    {
        /// <summary>
        /// 职位id
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 简历id
        /// </summary>
        public string ResumeId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.hire.bizflow.start";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("job_id", this.JobId);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("resume_id", this.ResumeId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("job_id", this.JobId);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("resume_id", this.ResumeId);
        }

        #endregion
    }
}
