using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.subject.list
    /// </summary>
    public class OapiEduSubjectListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduSubjectListResponse>
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
        /// 用户id
        /// </summary>
        public string OperatorUserid { get; set; }

        /// <summary>
        /// 学段编码
        /// </summary>
        public string PeriodCode { get; set; }

        /// <summary>
        /// 每页数据条数
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 排序规则（0:升序，1:降序）
        /// </summary>
        public Nullable<long> SortType { get; set; }

        /// <summary>
        /// 学科编码列表
        /// </summary>
        public string SubjectCodeList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.subject.list";
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
            parameters.Add("operator_userid", this.OperatorUserid);
            parameters.Add("period_code", this.PeriodCode);
            parameters.Add("size", this.Size);
            parameters.Add("sort_type", this.SortType);
            parameters.Add("subject_code_list", this.SubjectCodeList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateRequired("operator_userid", this.OperatorUserid);
            RequestValidator.ValidateRequired("period_code", this.PeriodCode);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxListSize("subject_code_list", this.SubjectCodeList, 999);
        }

        #endregion
    }
}
