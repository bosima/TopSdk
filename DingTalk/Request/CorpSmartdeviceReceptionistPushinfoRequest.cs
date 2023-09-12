using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.smartdevice.receptionist.pushinfo
    /// </summary>
    public class CorpSmartdeviceReceptionistPushinfoRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpSmartdeviceReceptionistPushinfoResponse>
    {
        /// <summary>
        /// 展示模板需要的变量数据
        /// </summary>
        public string DescContent { get; set; }

        /// <summary>
        /// 智能前台信息展示模板ID，需要向智能硬件团队申请
        /// </summary>
        public string DescTemplate { get; set; }

        /// <summary>
        /// 微应用agentID
        /// </summary>
        public Nullable<long> MicroappAgentId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.smartdevice.receptionist.pushinfo";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("desc_content", this.DescContent);
            parameters.Add("desc_template", this.DescTemplate);
            parameters.Add("microapp_agent_id", this.MicroappAgentId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("desc_content", this.DescContent);
            RequestValidator.ValidateRequired("desc_template", this.DescTemplate);
            RequestValidator.ValidateRequired("microapp_agent_id", this.MicroappAgentId);
        }

        #endregion
    }
}
