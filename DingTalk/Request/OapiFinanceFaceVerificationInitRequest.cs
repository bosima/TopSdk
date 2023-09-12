using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.finance.faceVerification.init
    /// </summary>
    public class OapiFinanceFaceVerificationInitRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiFinanceFaceVerificationInitResponse>
    {
        /// <summary>
        /// 生物信息（通过jsapi获取）
        /// </summary>
        public string BioInfo { get; set; }

        /// <summary>
        /// 证件姓名
        /// </summary>
        public string CertName { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCardNo { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        public string Scene { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string UserMobile { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.finance.faceVerification.init";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bio_info", this.BioInfo);
            parameters.Add("cert_name", this.CertName);
            parameters.Add("id_card_no", this.IdCardNo);
            parameters.Add("scene", this.Scene);
            parameters.Add("user_mobile", this.UserMobile);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("bio_info", this.BioInfo);
            RequestValidator.ValidateRequired("cert_name", this.CertName);
            RequestValidator.ValidateRequired("id_card_no", this.IdCardNo);
            RequestValidator.ValidateRequired("scene", this.Scene);
            RequestValidator.ValidateRequired("user_mobile", this.UserMobile);
        }

        #endregion
    }
}
