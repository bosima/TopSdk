using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.candidate.get
    /// </summary>
    public class OapiAtsCandidateGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsCandidateGetResponse>
    {
        /// <summary>
        /// 招聘业务标识
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 候选人id
        /// </summary>
        public string CandidateId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.candidate.get";
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
        }

        #endregion
    }
}
