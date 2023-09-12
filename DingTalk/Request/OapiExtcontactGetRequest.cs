using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.extcontact.get
    /// </summary>
    public class OapiExtcontactGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiExtcontactGetResponse>
    {
        /// <summary>
        /// 外部联系人的userId
        /// </summary>
        public string UserId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.extcontact.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("user_id", this.UserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("user_id", this.UserId);
            RequestValidator.ValidateMaxLength("user_id", this.UserId, 64);
        }

        #endregion
    }
}
