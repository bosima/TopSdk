using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.role.addrolesforemps
    /// </summary>
    public class OapiRoleAddrolesforempsRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRoleAddrolesforempsResponse>
    {
        /// <summary>
        /// 角色id list
        /// </summary>
        public string RoleIds { get; set; }

        /// <summary>
        /// 员工id list
        /// </summary>
        public string UserIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.role.addrolesforemps";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("roleIds", this.RoleIds);
            parameters.Add("userIds", this.UserIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("roleIds", this.RoleIds);
            RequestValidator.ValidateMaxListSize("roleIds", this.RoleIds, 20);
            RequestValidator.ValidateRequired("userIds", this.UserIds);
            RequestValidator.ValidateMaxListSize("userIds", this.UserIds, 20);
        }

        #endregion
    }
}
