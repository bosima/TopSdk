using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.service.get_suite_token
    /// </summary>
    public class OapiServiceGetSuiteTokenRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiServiceGetSuiteTokenResponse>
    {
        /// <summary>
        /// 套件key，开发者后台创建套件后获取
        /// </summary>
        public string SuiteKey { get; set; }

        /// <summary>
        /// 套件secret，开发者后台创建套件后获取
        /// </summary>
        public string SuiteSecret { get; set; }

        /// <summary>
        /// 钉钉推送的ticket
        /// </summary>
        public string SuiteTicket { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.service.get_suite_token";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("suite_key", this.SuiteKey);
            parameters.Add("suite_secret", this.SuiteSecret);
            parameters.Add("suite_ticket", this.SuiteTicket);
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
