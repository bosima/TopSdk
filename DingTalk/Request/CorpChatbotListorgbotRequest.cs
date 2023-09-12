using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.chatbot.listorgbot
    /// </summary>
    public class CorpChatbotListorgbotRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpChatbotListorgbotResponse>
    {
        /// <summary>
        /// 微应用id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 钉钉分配的类型
        /// </summary>
        public string Type { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.chatbot.listorgbot";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("type", this.Type);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion
    }
}
