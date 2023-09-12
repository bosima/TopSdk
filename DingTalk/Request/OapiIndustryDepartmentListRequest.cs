using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.industry.department.list
    /// </summary>
    public class OapiIndustryDepartmentListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiIndustryDepartmentListResponse>
    {
        /// <summary>
        /// 游标，不传默认1
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        /// <summary>
        /// 大小
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.industry.department.list";
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
