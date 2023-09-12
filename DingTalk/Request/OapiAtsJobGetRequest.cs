using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.job.get
    /// </summary>
    public class OapiAtsJobGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsJobGetResponse>
    {
        /// <summary>
        /// 业务唯一标识，接入前请提前沟通
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 职位唯一标识
        /// </summary>
        public string JobId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.job.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("job_id", this.JobId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("job_id", this.JobId);
        }

        #endregion
    }
}
