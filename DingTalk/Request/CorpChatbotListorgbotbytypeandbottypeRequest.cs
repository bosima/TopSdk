using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.chatbot.listorgbotbytypeandbottype
    /// </summary>
    public class CorpChatbotListorgbotbytypeandbottypeRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpChatbotListorgbotbytypeandbottypeResponse>
    {
        /// <summary>
        /// 2-企业对内机器人，3-企业对外机器人
        /// </summary>
        public Nullable<long> BotType { get; set; }

        /// <summary>
        /// 机器人类型(钉钉分配)
        /// </summary>
        public string Type { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.chatbot.listorgbotbytypeandbottype";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bot_type", this.BotType);
            parameters.Add("type", this.Type);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("bot_type", this.BotType);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion
    }
}
