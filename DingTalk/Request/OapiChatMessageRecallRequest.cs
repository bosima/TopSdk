using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.message.recall
    /// </summary>
    public class OapiChatMessageRecallRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatMessageRecallResponse>
    {
        /// <summary>
        /// 会话id
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        public string Msgid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.message.recall";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatid", this.Chatid);
            parameters.Add("msgid", this.Msgid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatid", this.Chatid);
            RequestValidator.ValidateRequired("msgid", this.Msgid);
        }

        #endregion
    }
}
