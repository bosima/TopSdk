using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.textbook.metadata.list
    /// </summary>
    public class OapiEduTextbookMetadataListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduTextbookMetadataListResponse>
    {
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
        public string OpUserId { get; set; }

        /// <summary>
        /// 父教材id
        /// </summary>
        public Nullable<long> ParentId { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 排序规则（0:升序，1:降序）
        /// </summary>
        public Nullable<long> SortType { get; set; }

        /// <summary>
        /// 学科编码
        /// </summary>
        public string SubjectCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.textbook.metadata.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("data_order_type", this.DataOrderType);
            parameters.Add("level", this.Level);
            parameters.Add("op_user_id", this.OpUserId);
            parameters.Add("parent_id", this.ParentId);
            parameters.Add("size", this.Size);
            parameters.Add("sort_type", this.SortType);
            parameters.Add("subject_code", this.SubjectCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateRequired("subject_code", this.SubjectCode);
        }

        #endregion
    }
}
