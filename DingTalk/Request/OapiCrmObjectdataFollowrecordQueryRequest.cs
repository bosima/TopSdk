using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.crm.objectdata.followrecord.query
    /// </summary>
    public class OapiCrmObjectdataFollowrecordQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCrmObjectdataFollowrecordQueryResponse>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string CurrentOperatorUserid { get; set; }

        /// <summary>
        /// 分页游标
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        public string QueryDsl { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.crm.objectdata.followrecord.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_operator_userid", this.CurrentOperatorUserid);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("query_dsl", this.QueryDsl);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

        #endregion
    }
}
