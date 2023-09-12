using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.grade.query
    /// </summary>
    public class OapiEduGradeQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduGradeQueryResponse>
    {
        /// <summary>
        /// 校区id
        /// </summary>
        public Nullable<long> CampusId { get; set; }

        /// <summary>
        /// 钉钉企业管理员
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 学段id
        /// </summary>
        public Nullable<long> PeriodId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.grade.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("campus_id", this.CampusId);
            parameters.Add("operator", this.Operator);
            parameters.Add("period_id", this.PeriodId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("operator", this.Operator);
        }

        #endregion
    }
}
