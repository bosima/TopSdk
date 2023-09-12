using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.message.corpconversation.status_bar.update
    /// </summary>
    public class OapiMessageCorpconversationStatusBarUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMessageCorpconversationStatusBarUpdateResponse>
    {
        /// <summary>
        /// 应用id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 状态栏背景色
        /// </summary>
        public string StatusBg { get; set; }

        /// <summary>
        /// 状态栏值
        /// </summary>
        public string StatusValue { get; set; }

        /// <summary>
        /// 工作通知任务id
        /// </summary>
        public Nullable<long> TaskId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.message.corpconversation.status_bar.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("status_bg", this.StatusBg);
            parameters.Add("status_value", this.StatusValue);
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
            RequestValidator.ValidateRequired("status_value", this.StatusValue);
            RequestValidator.ValidateRequired("task_id", this.TaskId);
        }

        #endregion
    }
}
