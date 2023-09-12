using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sns.get_persistent_code
    /// </summary>
    public class OapiSnsGetPersistentCodeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSnsGetPersistentCodeResponse>
    {
        /// <summary>
        /// 用户授权给钉钉开放应用的临时授权码
        /// </summary>
        public string TmpAuthCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sns.get_persistent_code";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("tmp_auth_code", this.TmpAuthCode);
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
