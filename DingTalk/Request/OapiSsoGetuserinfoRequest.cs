using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sso.getuserinfo
    /// </summary>
    public class OapiSsoGetuserinfoRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSsoGetuserinfoResponse>
    {
        /// <summary>
        /// 通过Oauth认证给URL带上的CODE
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 再次强调，此token不同于一般的accesstoken，需要调用获取微应用管理员免登需要的AccessToken
        /// </summary>
        public string Code { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sso.getuserinfo";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("access_token", this.AccessToken);
            parameters.Add("code", this.Code);
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
