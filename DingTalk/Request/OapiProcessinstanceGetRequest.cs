using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.processinstance.get
    /// </summary>
    public class OapiProcessinstanceGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessinstanceGetResponse>
    {
        /// <summary>
        /// 审批实例id
        /// </summary>
        public string ProcessInstanceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.processinstance.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("process_instance_id", this.ProcessInstanceId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("process_instance_id", this.ProcessInstanceId);
        }

        #endregion
    }
}
