using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.chatbot.updateorgbot
    /// </summary>
    public class CorpChatbotUpdateorgbotRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpChatbotUpdateorgbotResponse>
    {
        /// <summary>
        /// 创建时返回的机器人Id
        /// </summary>
        public Nullable<long> ChatbotId { get; set; }

        /// <summary>
        /// 头像的mediaId
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 机器人名字
        /// </summary>
        public string Name { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.chatbot.updateorgbot";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatbot_id", this.ChatbotId);
            parameters.Add("icon", this.Icon);
            parameters.Add("name", this.Name);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatbot_id", this.ChatbotId);
            RequestValidator.ValidateRequired("icon", this.Icon);
            RequestValidator.ValidateRequired("name", this.Name);
        }

        #endregion
    }
}
