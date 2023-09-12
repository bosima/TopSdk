using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.print.template.save
    /// </summary>
    public class OapiProcessPrintTemplateSaveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessPrintTemplateSaveResponse>
    {
        /// <summary>
        /// 字体
        /// </summary>
        public string Font { get; set; }

        /// <summary>
        /// 是否开启自定义打印
        /// </summary>
        public Nullable<bool> OpenCustomizePrint { get; set; }

        /// <summary>
        /// 审批流程唯一code
        /// </summary>
        public string ProcessCode { get; set; }

        /// <summary>
        /// vm文件
        /// </summary>
        public string Vm { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.print.template.save";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("font", this.Font);
            parameters.Add("open_customize_print", this.OpenCustomizePrint);
            parameters.Add("process_code", this.ProcessCode);
            parameters.Add("vm", this.Vm);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("font", this.Font);
            RequestValidator.ValidateRequired("process_code", this.ProcessCode);
            RequestValidator.ValidateRequired("vm", this.Vm);
        }

        #endregion
    }
}
