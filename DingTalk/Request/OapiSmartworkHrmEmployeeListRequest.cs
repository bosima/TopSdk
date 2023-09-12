using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.employee.list
    /// </summary>
    public class OapiSmartworkHrmEmployeeListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmEmployeeListResponse>
    {
        /// <summary>
        /// 微应用在企业的agentId
        /// </summary>
        public Nullable<long> Agentid { get; set; }

        /// <summary>
        /// 需要获取的花名册字段信息
        /// </summary>
        public string FieldFilterList { get; set; }

        /// <summary>
        /// 员工id列表
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.employee.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("field_filter_list", this.FieldFilterList);
            parameters.Add("userid_list", this.UseridList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("field_filter_list", this.FieldFilterList, 100);
            RequestValidator.ValidateRequired("userid_list", this.UseridList);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 50);
        }

        #endregion
    }
}
