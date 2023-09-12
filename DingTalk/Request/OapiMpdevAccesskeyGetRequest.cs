using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.mpdev.accesskey.get
    /// </summary>
    public class OapiMpdevAccesskeyGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMpdevAccesskeyGetResponse>
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        public string MiniappId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.mpdev.accesskey.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("miniapp_id", this.MiniappId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("miniapp_id", this.MiniappId);
        }

        #endregion
    }
}
