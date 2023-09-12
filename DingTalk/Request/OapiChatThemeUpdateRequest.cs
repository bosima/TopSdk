using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.theme.update
    /// </summary>
    public class OapiChatThemeUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatThemeUpdateResponse>
    {
        /// <summary>
        /// 会话id
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        public string Mediaid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.theme.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatid", this.Chatid);
            parameters.Add("mediaid", this.Mediaid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatid", this.Chatid);
            RequestValidator.ValidateRequired("mediaid", this.Mediaid);
        }

        #endregion
    }
}
