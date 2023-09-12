using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.v2.department.get
    /// </summary>
    public class OapiV2DepartmentGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiV2DepartmentGetResponse>
    {
        /// <summary>
        /// 部门id，根部门ID为1
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        /// <summary>
        /// 通讯录语言（默认zh_CN）
        /// </summary>
        public string Language { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.v2.department.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dept_id", this.DeptId);
            parameters.Add("language", this.Language);
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
