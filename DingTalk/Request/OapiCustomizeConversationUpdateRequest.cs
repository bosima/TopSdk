using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.customize.conversation.update
    /// </summary>
    public class OapiCustomizeConversationUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCustomizeConversationUpdateResponse>
    {
        /// <summary>
        /// 会话id
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// extensionKey
        /// </summary>
        public string ExtensionKey { get; set; }

        /// <summary>
        /// extensionValue
        /// </summary>
        public string ExtensionValue { get; set; }

        /// <summary>
        /// 员工账号
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.customize.conversation.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chat_id", this.ChatId);
            parameters.Add("extension_key", this.ExtensionKey);
            parameters.Add("extension_value", this.ExtensionValue);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chat_id", this.ChatId);
            RequestValidator.ValidateRequired("extension_key", this.ExtensionKey);
            RequestValidator.ValidateRequired("extension_value", this.ExtensionValue);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
