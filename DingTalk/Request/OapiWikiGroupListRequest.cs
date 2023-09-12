using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.wiki.group.list
    /// </summary>
    public class OapiWikiGroupListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWikiGroupListResponse>
    {
        /// <summary>
        /// 个人授权信息
        /// </summary>
        public string AuthCode { get; set; }

        /// <summary>
        /// 分页游标（默认0）
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 1:组织内公开可见 2:非组织内公开可见
        /// </summary>
        public Nullable<long> GroupType { get; set; }

        /// <summary>
        /// 1:管理员 2:编辑权限 3:只读权限
        /// </summary>
        public Nullable<long> RoleType { get; set; }

        /// <summary>
        /// 分页大小（默认20）
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.wiki.group.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auth_code", this.AuthCode);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("group_type", this.GroupType);
            parameters.Add("role_type", this.RoleType);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("auth_code", this.AuthCode);
            RequestValidator.ValidateRequired("group_type", this.GroupType);
            RequestValidator.ValidateRequired("role_type", this.RoleType);
        }

        #endregion
    }
}
