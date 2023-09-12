using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.crm.objectdata.customer.delete
    /// </summary>
    public class OapiCrmObjectdataCustomerDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCrmObjectdataCustomerDeleteResponse>
    {
        /// <summary>
        /// 客户实例ID
        /// </summary>
        public string DataId { get; set; }

        /// <summary>
        /// 操作人用户ID
        /// </summary>
        public string OperatorUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.crm.objectdata.customer.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("data_id", this.DataId);
            parameters.Add("operator_userid", this.OperatorUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("data_id", this.DataId);
            RequestValidator.ValidateRequired("operator_userid", this.OperatorUserid);
        }

        #endregion
    }
}
