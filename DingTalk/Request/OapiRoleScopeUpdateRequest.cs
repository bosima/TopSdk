using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.role.scope.update
    /// </summary>
    public class OapiRoleScopeUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRoleScopeUpdateResponse>
    {
        /// <summary>
        /// 部门ID列表数
        /// </summary>
        public string DeptIds { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public Nullable<long> RoleId { get; set; }

        /// <summary>
        /// 员工在企业中的ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.role.scope.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dept_ids", this.DeptIds);
            parameters.Add("role_id", this.RoleId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("dept_ids", this.DeptIds, 200);
            RequestValidator.ValidateRequired("role_id", this.RoleId);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
