using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.hrm.employee.getdismissionlist
    /// </summary>
    public class OapiHrmEmployeeGetdismissionlistRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiHrmEmployeeGetdismissionlistResponse>
    {
        /// <summary>
        /// 第几页，从1开始
        /// </summary>
        public Nullable<long> Current { get; set; }

        /// <summary>
        /// 操作人userid
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 一页多少数据，在1-100之间
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.hrm.employee.getdismissionlist";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current", this.Current);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("page_size", this.PageSize);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("current", this.Current);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

        #endregion
    }
}
