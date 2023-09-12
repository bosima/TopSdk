using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.role.visible.set
    /// </summary>
    public class OapiRoleVisibleSetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRoleVisibleSetResponse>
    {
        /// <summary>
        /// roleId
        /// </summary>
        public Nullable<long> RoleId { get; set; }

        /// <summary>
        /// roleId可见的roleIdList
        /// </summary>
        public string VisibleRoleIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.role.visible.set";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("role_id", this.RoleId);
            parameters.Add("visible_role_ids", this.VisibleRoleIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("role_id", this.RoleId);
            RequestValidator.ValidateRequired("visible_role_ids", this.VisibleRoleIds);
            RequestValidator.ValidateMaxListSize("visible_role_ids", this.VisibleRoleIds, 50);
        }

        #endregion
    }
}
