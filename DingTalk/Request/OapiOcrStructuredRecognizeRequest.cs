using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ocr.structured.recognize
    /// </summary>
    public class OapiOcrStructuredRecognizeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiOcrStructuredRecognizeResponse>
    {
        /// <summary>
        /// 识别图片地址
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// 识别图片类型, 身份证idcard，营业执照增值税发票invoice，营业执照blicense，银行卡bank_card，车牌car_no，机动车发票car_invoice，驾驶证driving_license，行驶证vehicle_license，火车票train_ticket，定额发票quota_invoice，出租车发票taxi_ticket，机票行程单air_itinerary
        /// </summary>
        public string Type { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ocr.structured.recognize";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("image_url", this.ImageUrl);
            parameters.Add("type", this.Type);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("image_url", this.ImageUrl);
            RequestValidator.ValidateMaxLength("image_url", this.ImageUrl, 1000);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion
    }
}
