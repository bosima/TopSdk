using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.scencegroup.file.downloadurl.get
    /// </summary>
    public class OapiImChatScencegroupFileDownloadurlGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatScencegroupFileDownloadurlGetResponse>
    {
        /// <summary>
        /// downloadCode 会包含在如聊天消息推送等链路中提供给业务方
        /// </summary>
        public string DownloadCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.scencegroup.file.downloadurl.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("download_code", this.DownloadCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("download_code", this.DownloadCode);
        }

        #endregion
    }
}
