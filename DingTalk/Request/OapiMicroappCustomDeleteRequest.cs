using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.microapp.custom.delete
    /// </summary>
    public class OapiMicroappCustomDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMicroappCustomDeleteResponse>
    {
        /// <summary>
        /// 定制应用id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 定制应用所属企业
        /// </summary>
        public string AppCorpId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.microapp.custom.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("app_corp_id", this.AppCorpId);
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
