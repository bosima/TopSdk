using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.wiki.resource.auth
    /// </summary>
    public class OapiWikiResourceAuthRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWikiResourceAuthResponse>
    {
        /// <summary>
        /// 应用agentId
        /// </summary>
        public Nullable<long> Agentid { get; set; }

        /// <summary>
        /// 个人授权信息
        /// </summary>
        public string AuthCode { get; set; }

        /// <summary>
        /// 是否是公开发布的知识库
        /// </summary>
        public Nullable<bool> IsPublic { get; set; }

        /// <summary>
        /// 请求授权的资源列表
        /// </summary>
        public string ResourceList { get; set; }

        /// <summary>
        /// 1:知识库，2:知识本，3:知识页
        /// </summary>
        public Nullable<long> ResourceType { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.wiki.resource.auth";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("auth_code", this.AuthCode);
            parameters.Add("is_public", this.IsPublic);
            parameters.Add("resource_list", this.ResourceList);
            parameters.Add("resource_type", this.ResourceType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agentid", this.Agentid);
            RequestValidator.ValidateRequired("auth_code", this.AuthCode);
            RequestValidator.ValidateRequired("is_public", this.IsPublic);
            RequestValidator.ValidateRequired("resource_list", this.ResourceList);
            RequestValidator.ValidateMaxListSize("resource_list", this.ResourceList, 999);
            RequestValidator.ValidateRequired("resource_type", this.ResourceType);
        }

        #endregion
    }
}
