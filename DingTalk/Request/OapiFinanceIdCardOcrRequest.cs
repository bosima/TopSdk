using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.finance.IdCard.ocr
    /// </summary>
    public class OapiFinanceIdCardOcrRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiFinanceIdCardOcrResponse>
    {
        /// <summary>
        /// 身份证反面照片地址
        /// </summary>
        public string BackPictureUrl { get; set; }

        /// <summary>
        /// 身份证正面照片地址
        /// </summary>
        public string FrontPictureUrl { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCardNo { get; set; }

        /// <summary>
        /// 请求标识（保证唯一）
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string UserMobile { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.finance.IdCard.ocr";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("back_picture_url", this.BackPictureUrl);
            parameters.Add("front_picture_url", this.FrontPictureUrl);
            parameters.Add("id_card_no", this.IdCardNo);
            parameters.Add("request_id", this.RequestId);
            parameters.Add("user_mobile", this.UserMobile);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("back_picture_url", this.BackPictureUrl);
            RequestValidator.ValidateRequired("front_picture_url", this.FrontPictureUrl);
            RequestValidator.ValidateRequired("id_card_no", this.IdCardNo);
            RequestValidator.ValidateRequired("request_id", this.RequestId);
            RequestValidator.ValidateRequired("user_mobile", this.UserMobile);
        }

        #endregion
    }
}
