using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.chatbot.addchatbotinstance
    /// </summary>
    public class CorpChatbotAddchatbotinstanceRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpChatbotAddchatbotinstanceResponse>
    {
        /// <summary>
        /// 机器人id，由钉钉事先分配
        /// </summary>
        public string ChatbotId { get; set; }

        /// <summary>
        /// 机器人头像(如果为空，默认是机器人安装时的头像)
        /// </summary>
        public string IconMediaId { get; set; }

        /// <summary>
        /// 机器人名字(如果为空，默认是机器人安装时的名字)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 创建群时返回的openConvsationId
        /// </summary>
        public string OpenConversationId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.chatbot.addchatbotinstance";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatbot_id", this.ChatbotId);
            parameters.Add("icon_media_id", this.IconMediaId);
            parameters.Add("name", this.Name);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatbot_id", this.ChatbotId);
            RequestValidator.ValidateRequired("open_conversation_id", this.OpenConversationId);
        }

        #endregion
    }
}
