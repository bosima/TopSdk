using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.wiki.doc.list
    /// </summary>
    public class OapiWikiDocListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWikiDocListResponse>
    {
        /// <summary>
        /// 应用agentId
        /// </summary>
        public Nullable<long> Agentid { get; set; }

        /// <summary>
        /// 分页游标（默认0）
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 知识本ID（加密后的值）
        /// </summary>
        public string RepoId { get; set; }

        /// <summary>
        /// 分页大小（默认20）
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.wiki.doc.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("repo_id", this.RepoId);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agentid", this.Agentid);
            RequestValidator.ValidateRequired("repo_id", this.RepoId);
        }

        #endregion
    }
}
