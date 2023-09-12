using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.v2.department.listsubid
    /// </summary>
    public class OapiV2DepartmentListsubidRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiV2DepartmentListsubidResponse>
    {
        /// <summary>
        /// 父部门id，根部门传1
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.v2.department.listsubid";
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
        }

        #endregion
    }
}
