using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.retail.user.token.check
    /// </summary>
    public class OapiRetailUserTokenCheckRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRetailUserTokenCheckResponse>
    {
        /// <summary>
        /// 业务身份
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// token信息
        /// </summary>
        public string Token { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.retail.user.token.check";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel", this.Channel);
            parameters.Add("token", this.Token);
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
