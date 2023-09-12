using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.dept.list
    /// </summary>
    public class OapiEduDeptListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduDeptListResponse>
    {
        /// <summary>
        /// 页码，从1开始
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页大小，最大30
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 父部门节点id，如果不填，则默认获取第一层级的部门节点
        /// </summary>
        public Nullable<long> SuperId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.dept.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("super_id", this.SuperId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

        #endregion
    }
}
