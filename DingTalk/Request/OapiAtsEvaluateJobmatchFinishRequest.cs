using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.evaluate.jobmatch.finish
    /// </summary>
    public class OapiAtsEvaluateJobmatchFinishRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsEvaluateJobmatchFinishResponse>
    {
        /// <summary>
        /// 招聘业务标识
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 测评结论
        /// </summary>
        public string Conclusion { get; set; }

        /// <summary>
        /// 请求扩展字段
        /// </summary>
        public string ExtData { get; set; }

        /// <summary>
        /// 外部测评系统测评记录id，全局唯一
        /// </summary>
        public string OuterEvaluateId { get; set; }

        /// <summary>
        /// 公网可以下载，不需要鉴权的评测报告下载地址，最大长度1024
        /// </summary>
        public string ReportDownloadUrl { get; set; }

        /// <summary>
        /// json格式的测评结果
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 岗位匹配得分，小数点后保留2位
        /// </summary>
        public string Score { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.evaluate.jobmatch.finish";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("conclusion", this.Conclusion);
            parameters.Add("ext_data", this.ExtData);
            parameters.Add("outer_evaluate_id", this.OuterEvaluateId);
            parameters.Add("report_download_url", this.ReportDownloadUrl);
            parameters.Add("result", this.Result);
            parameters.Add("score", this.Score);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("conclusion", this.Conclusion);
            RequestValidator.ValidateRequired("ext_data", this.ExtData);
            RequestValidator.ValidateRequired("outer_evaluate_id", this.OuterEvaluateId);
            RequestValidator.ValidateRequired("report_download_url", this.ReportDownloadUrl);
            RequestValidator.ValidateRequired("result", this.Result);
            RequestValidator.ValidateRequired("score", this.Score);
        }

        #endregion
    }
}
