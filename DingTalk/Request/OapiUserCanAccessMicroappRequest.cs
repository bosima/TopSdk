using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.can_access_microapp
    /// </summary>
    public class OapiUserCanAccessMicroappRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUserCanAccessMicroappResponse>
    {
        /// <summary>
        /// 微应用id
        /// </summary>
        public Nullable<long> AppId { get; set; }

        /// <summary>
        /// 员工唯一标识ID
        /// </summary>
        public string UserId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.can_access_microapp";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("appId", this.AppId);
            parameters.Add("userId", this.UserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
