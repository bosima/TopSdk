using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.microapp.set_visible_scopes
    /// </summary>
    public class OapiMicroappSetVisibleScopesRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMicroappSetVisibleScopesResponse>
    {
        /// <summary>
        /// 微应用实例化id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 设置可见的部门id列表，格式为JSON数组
        /// </summary>
        public List<long> DeptVisibleScopes { get; set; }

        /// <summary>
        /// 是否仅限管理员可见，true代表仅限管理员可见
        /// </summary>
        public Nullable<bool> IsHidden { get; set; }

        /// <summary>
        /// 设置可见的员工id列表，格式为JSON数组
        /// </summary>
        public List<string> UserVisibleScopes { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.microapp.set_visible_scopes";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentId", this.AgentId);
            parameters.Add("deptVisibleScopes", TopUtils.ObjectToJson(this.DeptVisibleScopes));
            parameters.Add("isHidden", this.IsHidden);
            parameters.Add("userVisibleScopes", TopUtils.ObjectToJson(this.UserVisibleScopes));
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
