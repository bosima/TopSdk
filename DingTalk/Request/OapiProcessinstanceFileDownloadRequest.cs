using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.processinstance.file.download
    /// </summary>
    public class OapiProcessinstanceFileDownloadRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessinstanceFileDownloadResponse>
    {
        /// <summary>
        /// 企业应用标识
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// 流程实例id
        /// </summary>
        public string ProcessInstanceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.processinstance.file.download";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("file_id", this.FileId);
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
            RequestValidator.ValidateRequired("file_id", this.FileId);
            RequestValidator.ValidateRequired("process_instance_id", this.ProcessInstanceId);
        }

        #endregion
    }
}
