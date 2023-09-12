using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.template.upgrade
    /// </summary>
    public class OapiProcessTemplateUpgradeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessTemplateUpgradeResponse>
    {
        /// <summary>
        /// 明细组件id
        /// </summary>
        public string DetailComponentId { get; set; }

        /// <summary>
        /// 数组或金额类组件id
        /// </summary>
        public string FormComponentId { get; set; }

        /// <summary>
        /// 流程code
        /// </summary>
        public string ProcessCode { get; set; }

        /// <summary>
        /// 其实是staffId
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.template.upgrade";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("detail_component_id", this.DetailComponentId);
            parameters.Add("form_component_id", this.FormComponentId);
            parameters.Add("process_code", this.ProcessCode);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("form_component_id", this.FormComponentId);
            RequestValidator.ValidateRequired("process_code", this.ProcessCode);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
