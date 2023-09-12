using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.finance.faceVerification.query
    /// </summary>
    public class OapiFinanceFaceVerificationQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiFinanceFaceVerificationQueryResponse>
    {
        /// <summary>
        /// 人脸识别业务编码
        /// </summary>
        public string BusinessId { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCardNo { get; set; }

        /// <summary>
        /// 人脸识别请求编码
        /// </summary>
        public string RequestCode { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string UserMobile { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.finance.faceVerification.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("business_id", this.BusinessId);
            parameters.Add("id_card_no", this.IdCardNo);
            parameters.Add("request_code", this.RequestCode);
            parameters.Add("user_mobile", this.UserMobile);
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
        }

        #endregion
    }
}
