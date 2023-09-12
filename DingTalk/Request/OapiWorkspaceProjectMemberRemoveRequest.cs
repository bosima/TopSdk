using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.project.member.remove
    /// </summary>
    public class OapiWorkspaceProjectMemberRemoveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceProjectMemberRemoveResponse>
    {
        /// <summary>
        /// 操作人工号
        /// </summary>
        public string OperatorStaffId { get; set; }

        /// <summary>
        /// 来源ID
        /// </summary>
        public string ProjectSourceId { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 待删除成员工号
        /// </summary>
        public string StaffId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.project.member.remove";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("operator_staff_id", this.OperatorStaffId);
            parameters.Add("project_source_id", this.ProjectSourceId);
            parameters.Add("source", this.Source);
            parameters.Add("staff_id", this.StaffId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("operator_staff_id", this.OperatorStaffId);
            RequestValidator.ValidateRequired("project_source_id", this.ProjectSourceId);
            RequestValidator.ValidateRequired("staff_id", this.StaffId);
        }

        #endregion
    }
}
