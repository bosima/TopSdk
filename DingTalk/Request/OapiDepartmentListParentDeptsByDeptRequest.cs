using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.department.list_parent_depts_by_dept
    /// </summary>
    public class OapiDepartmentListParentDeptsByDeptRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDepartmentListParentDeptsByDeptResponse>
    {
        /// <summary>
        /// 部门id
        /// </summary>
        public string Id { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.department.list_parent_depts_by_dept";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
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
