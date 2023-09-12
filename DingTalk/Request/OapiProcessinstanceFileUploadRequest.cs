using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.processinstance.file.upload
    /// </summary>
    public class OapiProcessinstanceFileUploadRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessinstanceFileUploadResponse>
    {
        /// <summary>
        /// 企业应用标识
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 流程实例id
        /// </summary>
        public string ProcessInstanceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.processinstance.file.upload";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("process_instance_id", this.ProcessInstanceId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("process_instance_id", this.ProcessInstanceId);
        }

        #endregion
    }
}
