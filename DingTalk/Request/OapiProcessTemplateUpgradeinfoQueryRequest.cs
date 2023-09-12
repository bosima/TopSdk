using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.template.upgradeinfo.query
    /// </summary>
    public class OapiProcessTemplateUpgradeinfoQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessTemplateUpgradeinfoQueryResponse>
    {
        /// <summary>
        /// 流程编码List<String>类型
        /// </summary>
        public string ProcessCodes { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.template.upgradeinfo.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("process_codes", this.ProcessCodes);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("process_codes", this.ProcessCodes);
            RequestValidator.ValidateMaxListSize("process_codes", this.ProcessCodes, 20);
        }

        #endregion
    }
}
