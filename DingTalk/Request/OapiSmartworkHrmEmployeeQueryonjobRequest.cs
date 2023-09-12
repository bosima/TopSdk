using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.employee.queryonjob
    /// </summary>
    public class OapiSmartworkHrmEmployeeQueryonjobRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmEmployeeQueryonjobResponse>
    {
        /// <summary>
        /// 分页起始值，默认0开始
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 分页大小，最大50
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 在职员工子状态筛选。2，试用期；3，正式；5，待离职；-1，无状态
        /// </summary>
        public string StatusList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.employee.queryonjob";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("offset", this.Offset);
            parameters.Add("size", this.Size);
            parameters.Add("status_list", this.StatusList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateMinValue("offset", this.Offset, 0);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 50);
            RequestValidator.ValidateMinValue("size", this.Size, 1);
            RequestValidator.ValidateRequired("status_list", this.StatusList);
            RequestValidator.ValidateMaxListSize("status_list", this.StatusList, 20);
        }

        #endregion
    }
}
