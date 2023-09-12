using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.role.visible.get
    /// </summary>
    public class OapiRoleVisibleGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRoleVisibleGetResponse>
    {
        /// <summary>
        /// 偏移量
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public Nullable<long> RoleId { get; set; }

        /// <summary>
        /// 批量大小
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.role.visible.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("offset", this.Offset);
            parameters.Add("role_id", this.RoleId);
            parameters.Add("size", this.Size);
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
