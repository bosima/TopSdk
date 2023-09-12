using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.v2.department.listparentbydept
    /// </summary>
    public class OapiV2DepartmentListparentbydeptRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiV2DepartmentListparentbydeptResponse>
    {
        /// <summary>
        /// 希望查询的部门的id，包含查询的部门本身
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.v2.department.listparentbydept";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dept_id", this.DeptId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("dept_id", this.DeptId);
        }

        #endregion
    }
}
