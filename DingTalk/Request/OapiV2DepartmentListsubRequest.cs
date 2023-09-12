using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.v2.department.listsub
    /// </summary>
    public class OapiV2DepartmentListsubRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiV2DepartmentListsubResponse>
    {
        /// <summary>
        /// 父部门id（如果不传，默认部门为根部门，根部门ID为1）,只支持查询下一级子部门，不支持查询多级子部门
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        /// <summary>
        /// 通讯录语言（默认zh_CN，未来会支持en_US）
        /// </summary>
        public string Language { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.v2.department.listsub";
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
        }

        #endregion
    }
}
