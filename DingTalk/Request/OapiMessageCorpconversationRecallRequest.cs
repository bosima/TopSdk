using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.message.corpconversation.recall
    /// </summary>
    public class OapiMessageCorpconversationRecallRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMessageCorpconversationRecallResponse>
    {
        /// <summary>
        /// 发送工作通知的微应用agentId
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 发送工作通知返回的taskId
        /// </summary>
        public Nullable<long> MsgTaskId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.message.corpconversation.recall";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("msg_task_id", this.MsgTaskId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("msg_task_id", this.MsgTaskId);
        }

        #endregion
    }
}
