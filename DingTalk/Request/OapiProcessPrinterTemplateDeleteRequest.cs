using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.printer.template.delete
    /// </summary>
    public class OapiProcessPrinterTemplateDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessPrinterTemplateDeleteResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Request { get; set; }

        public PrintVmClearRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.printer.template.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// PrintVmClearRequestDomain Data Structure.
/// </summary>
[Serializable]

public class PrintVmClearRequestDomain : TopObject
{
	        /// <summary>
	        /// 微应用agentId，ISV必填
	        /// </summary>
	        [XmlElement("agent_id")]
	        public Nullable<long> AgentId { get; set; }
	
	        /// <summary>
	        /// 流程code
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
}

        #endregion
    }
}
