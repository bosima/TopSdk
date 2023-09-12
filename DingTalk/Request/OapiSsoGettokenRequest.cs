using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sso.gettoken
    /// </summary>
    public class OapiSsoGettokenRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSsoGettokenResponse>
    {
        /// <summary>
        /// 企业Id
        /// </summary>
        public string Corpid { get; set; }

        /// <summary>
        /// 这里必须填写专属的SSOSecret
        /// </summary>
        public string Corpsecret { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sso.gettoken";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("corpid", this.Corpid);
            parameters.Add("corpsecret", this.Corpsecret);
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
