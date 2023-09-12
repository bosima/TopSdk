using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.file.upload.chunk
    /// </summary>
    public class OapiFileUploadChunkRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiFileUploadChunkResponse>, IDingTalkUploadRequest<DingTalk.Api.Response.OapiFileUploadChunkResponse>
    {
        /// <summary>
        /// 微应用的agentId
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 文件块号，从1开始计数
        /// </summary>
        public Nullable<long> ChunkSequence { get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        public FileItem File { get; set; }

        /// <summary>
        /// 上传事务id 需要utf-8 urlEncode
        /// </summary>
        public string UploadId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.file.upload.chunk";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("chunk_sequence", this.ChunkSequence);
            parameters.Add("upload_id", this.UploadId);
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
