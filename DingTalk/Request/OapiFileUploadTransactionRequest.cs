using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.file.upload.transaction
    /// </summary>
    public class OapiFileUploadTransactionRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiFileUploadTransactionResponse>
    {
        /// <summary>
        /// 微应用的agentId
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 文件总块数
        /// </summary>
        public Nullable<long> ChunkNumbers { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        public Nullable<long> FileSize { get; set; }

        /// <summary>
        /// 上传事务id 需要utf-8 urlEncode
        /// </summary>
        public string UploadId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.file.upload.transaction";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("chunk_numbers", this.ChunkNumbers);
            parameters.Add("file_size", this.FileSize);
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

        #endregion
    }
}
