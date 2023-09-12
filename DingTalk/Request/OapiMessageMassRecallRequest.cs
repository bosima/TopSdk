using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.message.mass.recall
    /// </summary>
    public class OapiMessageMassRecallRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMessageMassRecallResponse>
    {
        /// <summary>
        /// 消息发送任务id
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// 服务号的unionid
        /// </summary>
        public string Unionid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.message.mass.recall";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("task_id", this.TaskId);
            parameters.Add("unionid", this.Unionid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("task_id", this.TaskId);
            RequestValidator.ValidateMaxLength("task_id", this.TaskId, 128);
            RequestValidator.ValidateRequired("unionid", this.Unionid);
            RequestValidator.ValidateMaxLength("unionid", this.Unionid, 128);
        }

        #endregion
    }
}
