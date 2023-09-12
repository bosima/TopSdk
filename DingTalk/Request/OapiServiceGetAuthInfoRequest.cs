using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.service.get_auth_info
    /// </summary>
    public class OapiServiceGetAuthInfoRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiServiceGetAuthInfoResponse>
    {
        /// <summary>
        /// 授权方corpid
        /// </summary>
        public string AuthCorpid { get; set; }

        /// <summary>
        /// 套件key
        /// </summary>
        public string SuiteKey { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.service.get_auth_info";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auth_corpid", this.AuthCorpid);
            parameters.Add("suite_key", this.SuiteKey);
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
