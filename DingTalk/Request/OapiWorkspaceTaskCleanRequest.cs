using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.task.clean
    /// </summary>
    public class OapiWorkspaceTaskCleanRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceTaskCleanResponse>
    {
        /// <summary>
        /// 微应用agentId
        /// </summary>
        public Nullable<long> Agentid { get; set; }

        /// <summary>
        /// 企业corpId
        /// </summary>
        public string CorpId { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        public string OperatorUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.task.clean";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("corp_id", this.CorpId);
            parameters.Add("operator_userid", this.OperatorUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("corp_id", this.CorpId);
        }

        #endregion
    }
}
