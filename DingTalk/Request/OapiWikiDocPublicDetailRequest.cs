using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.wiki.doc.public.detail
    /// </summary>
    public class OapiWikiDocPublicDetailRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWikiDocPublicDetailResponse>
    {
        /// <summary>
        /// 应用agentId
        /// </summary>
        public Nullable<long> Agentid { get; set; }

        /// <summary>
        /// 知识页ID（加密后的值）
        /// </summary>
        public string DocId { get; set; }

        /// <summary>
        /// 知识库ID（加密后的值）
        /// </summary>
        public string GroupId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.wiki.doc.public.detail";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("doc_id", this.DocId);
            parameters.Add("group_id", this.GroupId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agentid", this.Agentid);
            RequestValidator.ValidateRequired("doc_id", this.DocId);
            RequestValidator.ValidateRequired("group_id", this.GroupId);
        }

        #endregion
    }
}
