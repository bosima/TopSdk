using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sns.getuserinfo
    /// </summary>
    public class OapiSnsGetuserinfoRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSnsGetuserinfoResponse>
    {
        /// <summary>
        /// 用户授权给开放应用的token
        /// </summary>
        public string SnsToken { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sns.getuserinfo";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("sns_token", this.SnsToken);
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
