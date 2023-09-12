using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.microapp.listbypage
    /// </summary>
    public class OapiMicroappListbypageRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMicroappListbypageResponse>
    {
        /// <summary>
        /// 微应用id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 大小
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.microapp.listbypage";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentId", this.AgentId);
            parameters.Add("offset", this.Offset);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agentId", this.AgentId);
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
