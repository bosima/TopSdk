using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.kac.datav.annual_report.get
    /// </summary>
    public class OapiKacDatavAnnualReportGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiKacDatavAnnualReportGetResponse>
    {
        /// <summary>
        /// 部门id，当type=2时该参数需存在
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        /// <summary>
        /// 年报的数据维度，1-企业维度，2-部门维度，3-员工维度（员工维度的数据需要额外授权，请联系对接BD)
        /// </summary>
        public Nullable<long> Type { get; set; }

        /// <summary>
        /// 用户id，当type=3时该参数需存在
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 年份标识
        /// </summary>
        public string Year { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.kac.datav.annual_report.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dept_id", this.DeptId);
            parameters.Add("type", this.Type);
            parameters.Add("user_id", this.UserId);
            parameters.Add("year", this.Year);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateMaxLength("user_id", this.UserId, 128);
            RequestValidator.ValidateRequired("year", this.Year);
            RequestValidator.ValidateMaxLength("year", this.Year, 32);
        }

        #endregion
    }
}
