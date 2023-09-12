using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.service.activate_suite
    /// </summary>
    public class OapiServiceActivateSuiteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiServiceActivateSuiteResponse>
    {
        /// <summary>
        /// 授权方corpid
        /// </summary>
        public string AuthCorpid { get; set; }

        /// <summary>
        /// 永久授权码，从get_permanent_code接口中获取
        /// </summary>
        public string PermanentCode { get; set; }

        /// <summary>
        /// 套件key
        /// </summary>
        public string SuiteKey { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.service.activate_suite";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auth_corpid", this.AuthCorpid);
            parameters.Add("permanent_code", this.PermanentCode);
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
