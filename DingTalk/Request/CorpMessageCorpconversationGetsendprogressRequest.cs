using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.message.corpconversation.getsendprogress
    /// </summary>
    public class CorpMessageCorpconversationGetsendprogressRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpMessageCorpconversationGetsendprogressResponse>
    {
        /// <summary>
        /// 发送消息时使用的微应用的id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 发送消息时钉钉返回的任务id
        /// </summary>
        public Nullable<long> TaskId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.message.corpconversation.getsendprogress";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("task_id", this.TaskId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("task_id", this.TaskId);
        }

        #endregion
    }
}
