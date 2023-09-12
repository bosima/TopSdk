using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.cspace.auth.generate
    /// </summary>
    public class OapiCspaceAuthGenerateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCspaceAuthGenerateResponse>
    {
        /// <summary>
        /// 微应用的agentId
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 被授权的应用appId
        /// </summary>
        public Nullable<long> AppId { get; set; }

        /// <summary>
        /// 授权码有效期，单位为日，为空则表示永久授权
        /// </summary>
        public Nullable<long> Duration { get; set; }

        /// <summary>
        /// 授权访问的文件id列表，id之间用英文逗号隔开，如"fileId1,fileId2", type=download时必须传递
        /// </summary>
        public string FileIds { get; set; }

        /// <summary>
        /// 授权访问的路径，如授权访问所有文件传"/"，授权访问/doc文件夹传"/doc/"，需要utf-8 urlEncode, type=add时必须传递
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 权限类型，目前支持上传和预览，上传请传add，预览请传download
        /// </summary>
        public string Type { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.cspace.auth.generate";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("app_id", this.AppId);
            parameters.Add("duration", this.Duration);
            parameters.Add("file_ids", this.FileIds);
            parameters.Add("path", this.Path);
            parameters.Add("type", this.Type);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("app_id", this.AppId);
            RequestValidator.ValidateMaxListSize("file_ids", this.FileIds, 20);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion
    }
}
