using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.scencegroup.interactivecard.callback.register
    /// </summary>
    public class OapiImChatScencegroupInteractivecardCallbackRegisterRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatScencegroupInteractivecardCallbackRegisterResponse>
    {
        /// <summary>
        /// 加密密钥用于校验来源
        /// </summary>
        public string ApiSecret { get; set; }

        /// <summary>
        /// callback地址的路由Key，一个key仅可映射一个callbackUrl，不传值企业内部应用默认为orgId，企业三方应用默认为SuiteKey
        /// </summary>
        public string CallbackRouteKey { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 是否强制覆盖更新
        /// </summary>
        public Nullable<bool> ForceUpdate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.scencegroup.interactivecard.callback.register";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("api_secret", this.ApiSecret);
            parameters.Add("callbackRouteKey", this.CallbackRouteKey);
            parameters.Add("callback_url", this.CallbackUrl);
            parameters.Add("forceUpdate", this.ForceUpdate);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("callback_url", this.CallbackUrl);
        }

        #endregion
    }
}
