using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.finance.faceVerification.update
    /// </summary>
    public class OapiFinanceFaceVerificationUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiFinanceFaceVerificationUpdateResponse>
    {
        /// <summary>
        /// 人脸识别业务编码，初始化返回值中获取
        /// </summary>
        public string BusinessId { get; set; }

        /// <summary>
        /// 错误原因，jsapi调用返回错误原因
        /// </summary>
        public string FailReason { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCardNo { get; set; }

        /// <summary>
        /// 人脸识别请求编码，初始化返回值中获取
        /// </summary>
        public string RequestCode { get; set; }

        /// <summary>
        /// 错误码，jsapi调用返回错误码
        /// </summary>
        public string ResultCode { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string UserMobile { get; set; }

        /// <summary>
        /// 校验结果
        /// </summary>
        public string VerifyResult { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.finance.faceVerification.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("business_id", this.BusinessId);
            parameters.Add("fail_reason", this.FailReason);
            parameters.Add("id_card_no", this.IdCardNo);
            parameters.Add("request_code", this.RequestCode);
            parameters.Add("result_code", this.ResultCode);
            parameters.Add("user_mobile", this.UserMobile);
            parameters.Add("verify_result", this.VerifyResult);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("business_id", this.BusinessId);
            RequestValidator.ValidateRequired("id_card_no", this.IdCardNo);
            RequestValidator.ValidateRequired("request_code", this.RequestCode);
            RequestValidator.ValidateRequired("user_mobile", this.UserMobile);
            RequestValidator.ValidateRequired("verify_result", this.VerifyResult);
        }

        #endregion
    }
}
