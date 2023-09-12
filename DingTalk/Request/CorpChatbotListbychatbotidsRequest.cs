using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.chatbot.listbychatbotids
    /// </summary>
    public class CorpChatbotListbychatbotidsRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpChatbotListbychatbotidsResponse>
    {
        /// <summary>
        /// chatbotId列表
        /// </summary>
        public string ChatbotIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.chatbot.listbychatbotids";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatbot_ids", this.ChatbotIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatbot_ids", this.ChatbotIds);
            RequestValidator.ValidateMaxListSize("chatbot_ids", this.ChatbotIds, 20);
        }

        #endregion
    }
}
