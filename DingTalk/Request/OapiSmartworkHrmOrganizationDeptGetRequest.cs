using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.organization.dept.get
    /// </summary>
    public class OapiSmartworkHrmOrganizationDeptGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmOrganizationDeptGetResponse>
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        /// <summary>
        /// 字段 code 列表
        /// </summary>
        public string FieldCodeList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.organization.dept.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dept_id", this.DeptId);
            parameters.Add("field_code_list", this.FieldCodeList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("dept_id", this.DeptId);
            RequestValidator.ValidateRequired("field_code_list", this.FieldCodeList);
            RequestValidator.ValidateMaxListSize("field_code_list", this.FieldCodeList, 999);
        }

        #endregion
    }
}
