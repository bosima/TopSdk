using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sns.gettoken
    /// </summary>
    public class OapiSnsGettokenRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSnsGettokenResponse>
    {
        /// <summary>
        /// 由钉钉开放平台提供给开放应用的唯一标识
        /// </summary>
        public string Appid { get; set; }

        /// <summary>
        /// 由钉钉开放平台提供的密钥
        /// </summary>
        public string Appsecret { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sns.gettoken";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("appid", this.Appid);
            parameters.Add("appsecret", this.Appsecret);
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
