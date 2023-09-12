using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.period.metadata.list
    /// </summary>
    public class OapiEduPeriodMetadataListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduPeriodMetadataListResponse>
    {
        /// <summary>
        /// 地区编码
        /// </summary>
        public string AreaCode { get; set; }

        /// <summary>
        /// 游标
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 排序依赖字段类型
        /// </summary>
        public Nullable<long> DataOrderType { get; set; }

        /// <summary>
        /// 层级
        /// </summary>
        public Nullable<long> Level { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public string OperatorUserid { get; set; }

        /// <summary>
        /// 父id
        /// </summary>
        public Nullable<long> ParentId { get; set; }

        /// <summary>
        /// 每页数据条数
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 排序规则（0:升序，1:降序）
        /// </summary>
        public Nullable<long> SortType { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.period.metadata.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("area_code", this.AreaCode);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("data_order_type", this.DataOrderType);
            parameters.Add("level", this.Level);
            parameters.Add("operator_userid", this.OperatorUserid);
            parameters.Add("parent_id", this.ParentId);
            parameters.Add("size", this.Size);
            parameters.Add("sort_type", this.SortType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("area_code", this.AreaCode);
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateRequired("operator_userid", this.OperatorUserid);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
