using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.role.simplelist
    /// </summary>
    public class CorpRoleSimplelistRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpRoleSimplelistResponse>
    {
        /// <summary>
        /// 分页偏移
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public Nullable<long> RoleId { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.role.simplelist";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
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
