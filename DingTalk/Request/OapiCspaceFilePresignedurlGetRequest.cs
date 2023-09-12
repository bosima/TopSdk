using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.cspace.file.presignedurl.get
    /// </summary>
    public class OapiCspaceFilePresignedurlGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCspaceFilePresignedurlGetResponse>
    {
        /// <summary>
        /// 钉盘文件ID
        /// </summary>
        public string Dentryid { get; set; }

        /// <summary>
        /// 签名URL的有效期，不传的话为默认值15分钟
        /// </summary>
        public Nullable<long> ExpireSeconds { get; set; }

        /// <summary>
        /// 是否为内部调用，统一传false
        /// </summary>
        public Nullable<bool> InnerInvoke { get; set; }

        /// <summary>
        /// 钉盘空间ID
        /// </summary>
        public Nullable<long> Spaceid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.cspace.file.presignedurl.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dentryid", this.Dentryid);
            parameters.Add("expire_seconds", this.ExpireSeconds);
            parameters.Add("inner_invoke", this.InnerInvoke);
            parameters.Add("spaceid", this.Spaceid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("dentryid", this.Dentryid);
            RequestValidator.ValidateRequired("spaceid", this.Spaceid);
        }

        #endregion
    }
}
