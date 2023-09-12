using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.industry.user.list
    /// </summary>
    public class OapiIndustryUserListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiIndustryUserListResponse>
    {
        /// <summary>
        /// 游标位置
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// 页尺寸
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.industry.user.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("dept_id", this.DeptId);
            parameters.Add("role", this.Role);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("dept_id", this.DeptId);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
