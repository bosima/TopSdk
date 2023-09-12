using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.cspace.get_custom_space
    /// </summary>
    public class OapiCspaceGetCustomSpaceRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCspaceGetCustomSpaceResponse>
    {
        /// <summary>
        /// ISV调用时传入，微应用agentId
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 企业调用时传入，需要为10个字节以内的字符串，仅可包含字母和数字，大小写不敏感
        /// </summary>
        public string Domain { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.cspace.get_custom_space";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("domain", this.Domain);
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
