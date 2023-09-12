using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.org.setshortcut
    /// </summary>
    public class OapiOrgSetshortcutRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiOrgSetshortcutResponse>
    {
        /// <summary>
        /// 微应用实例id列表
        /// </summary>
        public string AgentIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.org.setshortcut";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentIds", this.AgentIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("agentIds", this.AgentIds, 20);
        }

        #endregion
    }
}
