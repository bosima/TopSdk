using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.role.deleterole
    /// </summary>
    public class OapiRoleDeleteroleRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRoleDeleteroleResponse>
    {
        /// <summary>
        /// 角色id
        /// </summary>
        public Nullable<long> RoleId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.role.deleterole";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("role_id", this.RoleId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("role_id", this.RoleId);
        }

        #endregion
    }
}
