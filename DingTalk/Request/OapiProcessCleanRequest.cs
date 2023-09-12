using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.clean
    /// </summary>
    public class OapiProcessCleanRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessCleanResponse>
    {
        /// <summary>
        /// 企业id
        /// </summary>
        public string Corpid { get; set; }

        /// <summary>
        /// 模板唯一码
        /// </summary>
        public string ProcessCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.clean";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("corpid", this.Corpid);
            parameters.Add("process_code", this.ProcessCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("process_code", this.ProcessCode);
        }

        #endregion
    }
}
