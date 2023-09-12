using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.tasklist.hidden.cancel
    /// </summary>
    public class OapiWorkspaceTasklistHiddenCancelRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceTasklistHiddenCancelResponse>
    {
        /// <summary>
        /// 微应用agentId
        /// </summary>
        public Nullable<long> Agentid { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        public string OperatorUserid { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.tasklist.hidden.cancel";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("operator_userid", this.OperatorUserid);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("operator_userid", this.OperatorUserid);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
