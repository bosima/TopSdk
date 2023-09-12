using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.file.upload.single
    /// </summary>
    public class OapiFileUploadSingleRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiFileUploadSingleResponse>, IDingTalkUploadRequest<DingTalk.Api.Response.OapiFileUploadSingleResponse>
    {
        /// <summary>
        /// 微应用的agentId
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        public FileItem File { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        public Nullable<long> FileSize { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.file.upload.single";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("file_size", this.FileSize);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("file", this.File);
            return parameters;
        }

        #endregion

    }
}
