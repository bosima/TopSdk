using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.task.deletebyproject
    /// </summary>
    public class OapiWorkspaceTaskDeletebyprojectRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceTaskDeletebyprojectResponse>
    {
        /// <summary>
        /// 微应用agentId
        /// </summary>
        public Nullable<long> MicroappAgentId { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        public string OperatorUserid { get; set; }

        /// <summary>
        /// 任务所属项目(虚拟企业），基于项目空间的项目
        /// </summary>
        public string ProjectId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.task.deletebyproject";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("microapp_agent_id", this.MicroappAgentId);
            parameters.Add("operator_userid", this.OperatorUserid);
            parameters.Add("project_id", this.ProjectId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("operator_userid", this.OperatorUserid);
            RequestValidator.ValidateRequired("project_id", this.ProjectId);
        }

        #endregion
    }
}
