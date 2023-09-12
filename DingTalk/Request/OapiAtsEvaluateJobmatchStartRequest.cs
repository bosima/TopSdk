using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.evaluate.jobmatch.start
    /// </summary>
    public class OapiAtsEvaluateJobmatchStartRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsEvaluateJobmatchStartResponse>
    {
        /// <summary>
        /// 招聘业务标识
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 候选人id
        /// </summary>
        public string CandidateId { get; set; }

        /// <summary>
        /// 职位类型码，调用时请申请职位类型码表
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// json格式的字符串，存放请求扩展信息
        /// </summary>
        public string ExtData { get; set; }

        /// <summary>
        /// 邀请填写测评的url
        /// </summary>
        public string InviteUrl { get; set; }

        /// <summary>
        /// 候选人id
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// 外部测评系统的具体某一次测评的id，全局唯一
        /// </summary>
        public string OuterEvaluateId { get; set; }

        /// <summary>
        /// 测评结果的url
        /// </summary>
        public string ResultUrl { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.evaluate.jobmatch.start";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("candidate_id", this.CandidateId);
            parameters.Add("category", this.Category);
            parameters.Add("ext_data", this.ExtData);
            parameters.Add("invite_url", this.InviteUrl);
            parameters.Add("job_id", this.JobId);
            parameters.Add("outer_evaluate_id", this.OuterEvaluateId);
            parameters.Add("result_url", this.ResultUrl);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("candidate_id", this.CandidateId);
            RequestValidator.ValidateRequired("category", this.Category);
            RequestValidator.ValidateRequired("ext_data", this.ExtData);
            RequestValidator.ValidateRequired("invite_url", this.InviteUrl);
            RequestValidator.ValidateRequired("job_id", this.JobId);
            RequestValidator.ValidateRequired("outer_evaluate_id", this.OuterEvaluateId);
            RequestValidator.ValidateRequired("result_url", this.ResultUrl);
        }

        #endregion
    }
}
