using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.get_by_mobile
    /// </summary>
    public class OapiUserGetByMobileRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUserGetByMobileResponse>
    {
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.get_by_mobile";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("mobile", this.Mobile);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("mobile", this.Mobile);
        }

        #endregion
    }
}
