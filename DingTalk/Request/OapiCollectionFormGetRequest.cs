using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.collection.form.get
    /// </summary>
    public class OapiCollectionFormGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCollectionFormGetResponse>
    {
        /// <summary>
        /// 毫秒级时间戳
        /// </summary>
        public string ActionDate { get; set; }

        /// <summary>
        /// code
        /// </summary>
        public string FormCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.collection.form.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("action_date", this.ActionDate);
            parameters.Add("form_code", this.FormCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("action_date", this.ActionDate);
            RequestValidator.ValidateRequired("form_code", this.FormCode);
        }

        #endregion
    }
}
