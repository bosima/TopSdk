using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.service.get_permanent_code
    /// </summary>
    public class OapiServiceGetPermanentCodeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiServiceGetPermanentCodeResponse>
    {
        /// <summary>
        /// 回调接口（tmp_auth_code）获取的临时授权码
        /// </summary>
        public string TmpAuthCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.service.get_permanent_code";
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
