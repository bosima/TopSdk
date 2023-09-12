using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.v2.user.list
    /// </summary>
    public class OapiV2UserListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiV2UserListResponse>
    {
        /// <summary>
        /// 是否返回访问受限的员工
        /// </summary>
        public Nullable<bool> ContainAccessLimit { get; set; }

        /// <summary>
        /// 游标
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// 排序字段，默认custom。或者以下取值entry_asc、entry_desc、modify_asc、modify_desc、custom
        /// </summary>
        public string OrderField { get; set; }

        /// <summary>
        /// 分页长度
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.v2.user.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("contain_access_limit", this.ContainAccessLimit);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("dept_id", this.DeptId);
            parameters.Add("language", this.Language);
            parameters.Add("order_field", this.OrderField);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateMaxValue("cursor", this.Cursor, 100000);
            RequestValidator.ValidateMinValue("cursor", this.Cursor, 0);
            RequestValidator.ValidateRequired("dept_id", this.DeptId);
            RequestValidator.ValidateMinValue("dept_id", this.DeptId, 1);
            RequestValidator.ValidateMaxLength("language", this.Language, 6);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 100);
            RequestValidator.ValidateMinValue("size", this.Size, 1);
        }

        #endregion
    }
}
