using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.message.corpconversation.sendmock
    /// </summary>
    public class CorpMessageCorpconversationSendmockRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpMessageCorpconversationSendmockResponse>
    {
        /// <summary>
        /// 消息体
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public string MessageType { get; set; }

        /// <summary>
        /// 微应用agentId
        /// </summary>
        public Nullable<long> MicroappAgentId { get; set; }

        /// <summary>
        /// 消息接收者部门列表
        /// </summary>
        public string ToParty { get; set; }

        /// <summary>
        /// 消息接收者userid列表
        /// </summary>
        public string ToUser { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.message.corpconversation.sendmock";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("message", this.Message);
            parameters.Add("message_type", this.MessageType);
            parameters.Add("microapp_agent_id", this.MicroappAgentId);
            parameters.Add("to_party", this.ToParty);
            parameters.Add("to_user", this.ToUser);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("message", this.Message);
            RequestValidator.ValidateRequired("message_type", this.MessageType);
            RequestValidator.ValidateRequired("microapp_agent_id", this.MicroappAgentId);
            RequestValidator.ValidateRequired("to_party", this.ToParty);
            RequestValidator.ValidateMaxListSize("to_party", this.ToParty, 20);
            RequestValidator.ValidateRequired("to_user", this.ToUser);
            RequestValidator.ValidateMaxListSize("to_user", this.ToUser, 20);
        }

        #endregion
    }
}
