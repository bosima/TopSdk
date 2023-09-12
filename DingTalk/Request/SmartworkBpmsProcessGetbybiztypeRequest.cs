using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.smartwork.bpms.process.getbybiztype
    /// </summary>
    public class SmartworkBpmsProcessGetbybiztypeRequest : BaseDingTalkRequest<DingTalk.Api.Response.SmartworkBpmsProcessGetbybiztypeResponse>
    {
        /// <summary>
        /// 套件开发时与审批约定的业务标识
        /// </summary>
        public string BizType { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.smartwork.bpms.process.getbybiztype";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_type", this.BizType);
        }

        #endregion
    }
}
