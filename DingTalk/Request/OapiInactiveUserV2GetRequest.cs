using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.inactive.user.v2.get
    /// </summary>
    public class OapiInactiveUserV2GetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiInactiveUserV2GetResponse>
    {
        /// <summary>
        /// 过滤部门id列表，不传表示查询整个企业
        /// </summary>
        public string DeptIds { get; set; }

        /// <summary>
        /// 是否活跃 false不活跃 true 活跃
        /// </summary>
        public Nullable<bool> IsActive { get; set; }

        /// <summary>
        /// 获取数据偏移量，第一页使用0，后面页使用接口返回的nextCursor
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 查询日期, 日期格式yyyyMMdd
        /// </summary>
        public string QueryDate { get; set; }

        /// <summary>
        /// 获取数据size,最大100
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.inactive.user.v2.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dept_ids", this.DeptIds);
            parameters.Add("is_active", this.IsActive);
            parameters.Add("offset", this.Offset);
            parameters.Add("query_date", this.QueryDate);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("dept_ids", this.DeptIds, 100);
            RequestValidator.ValidateRequired("is_active", this.IsActive);
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateRequired("query_date", this.QueryDate);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
