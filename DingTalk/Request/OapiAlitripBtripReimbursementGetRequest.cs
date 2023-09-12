using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.reimbursement.get
    /// </summary>
    public class OapiAlitripBtripReimbursementGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripReimbursementGetResponse>
    {
        /// <summary>
        /// corp id
        /// </summary>
        public string Corpid { get; set; }

        /// <summary>
        /// 第三方流程id
        /// </summary>
        public string ThirdpartyFlowId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.reimbursement.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("corpid", this.Corpid);
            parameters.Add("thirdparty_flow_id", this.ThirdpartyFlowId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("corpid", this.Corpid);
            RequestValidator.ValidateRequired("thirdparty_flow_id", this.ThirdpartyFlowId);
        }

        #endregion
    }
}
