using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.smartwork.bpms.processinstance.getwithform
    /// </summary>
    public class SmartworkBpmsProcessinstanceGetwithformRequest : BaseDingTalkRequest<DingTalk.Api.Response.SmartworkBpmsProcessinstanceGetwithformResponse>
    {
        /// <summary>
        /// 审批实例id
        /// </summary>
        public string ProcessInstanceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.smartwork.bpms.processinstance.getwithform";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
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
