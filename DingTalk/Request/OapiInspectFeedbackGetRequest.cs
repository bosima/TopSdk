using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.inspect.feedback.get
    /// </summary>
    public class OapiInspectFeedbackGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiInspectFeedbackGetResponse>
    {
        /// <summary>
        /// 表单标识（传空值，暂时保留）
        /// </summary>
        public string FormId { get; set; }

        /// <summary>
        /// 巡店任务唯一标识
        /// </summary>
        public string TaskId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.inspect.feedback.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("form_id", this.FormId);
            parameters.Add("task_id", this.TaskId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("task_id", this.TaskId);
        }

        #endregion
    }
}
