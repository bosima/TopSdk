using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sns.get_sns_token
    /// </summary>
    public class OapiSnsGetSnsTokenRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSnsGetSnsTokenResponse>
    {
        /// <summary>
        /// 用户的openid
        /// </summary>
        public string Openid { get; set; }

        /// <summary>
        /// 用户授权给钉钉开放应用的持久授权码
        /// </summary>
        public string PersistentCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sns.get_sns_token";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("openid", this.Openid);
            parameters.Add("persistent_code", this.PersistentCode);
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
