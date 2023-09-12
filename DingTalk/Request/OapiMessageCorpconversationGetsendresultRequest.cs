using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.message.corpconversation.getsendresult
    /// </summary>
    public class OapiMessageCorpconversationGetsendresultRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMessageCorpconversationGetsendresultResponse>
    {
        /// <summary>
        /// 微应用的agentid
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 异步任务的id
        /// </summary>
        public Nullable<long> TaskId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.message.corpconversation.getsendresult";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
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
        }

        #endregion
    }
}
