using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.department.list
    /// </summary>
    public class OapiDepartmentListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDepartmentListResponse>
    {
        /// <summary>
        /// 是否递归部门的全部子部门，ISV微应用固定传递false。
        /// </summary>
        public Nullable<bool> FetchChild { get; set; }

        /// <summary>
        /// 父部门id(如果不传，默认部门为根部门，根部门ID为1)
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 通讯录语言(默认zh_CN，未来会支持en_US)
        /// </summary>
        public string Lang { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.department.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fetch_child", this.FetchChild);
            parameters.Add("id", this.Id);
            parameters.Add("lang", this.Lang);
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
