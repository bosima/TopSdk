using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.v2.safe.setdisable
    /// </summary>
    public class OapiV2SafeSetdisableRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiV2SafeSetdisableResponse>
    {
        /// <summary>
        /// 冻结原因
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.v2.safe.setdisable";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("reason", this.Reason);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("reason", this.Reason);
            RequestValidator.ValidateMaxLength("reason", this.Reason, 20);
            RequestValidator.ValidateRequired("userid", this.Userid);
            RequestValidator.ValidateMaxLength("userid", this.Userid, 64);
        }

        #endregion
    }
}
