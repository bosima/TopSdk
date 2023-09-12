using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.evaluate.jobmatch.cancel
    /// </summary>
    public class OapiAtsEvaluateJobmatchCancelRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsEvaluateJobmatchCancelResponse>
    {
        /// <summary>
        /// 招聘业务标识
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 请求扩展字段
        /// </summary>
        public string ExtData { get; set; }

        /// <summary>
        /// 外部测评系统测评id，全局唯一
        /// </summary>
        public string OuterEvaluateId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.evaluate.jobmatch.cancel";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("ext_data", this.ExtData);
            parameters.Add("outer_evaluate_id", this.OuterEvaluateId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("ext_data", this.ExtData);
            RequestValidator.ValidateRequired("outer_evaluate_id", this.OuterEvaluateId);
        }

        #endregion
    }
}
