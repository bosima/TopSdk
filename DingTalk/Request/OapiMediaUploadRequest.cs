using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.media.upload
    /// </summary>
    public class OapiMediaUploadRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMediaUploadResponse>, IDingTalkUploadRequest<DingTalk.Api.Response.OapiMediaUploadResponse>
    {
        /// <summary>
        /// form-data中媒体文件标识，有filename、filelength、content-type等信息
        /// </summary>
        public FileItem Media { get; set; }

        /// <summary>
        /// 媒体文件类型，分别有图片（image）、语音（voice）、普通文件(file)
        /// </summary>
        public string Type { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.media.upload";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("type", this.Type);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("media", this.Media);
        }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("media", this.Media);
            return parameters;
        }

        #endregion

    }
}
