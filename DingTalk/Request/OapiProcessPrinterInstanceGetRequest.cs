using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.printer.instance.get
    /// </summary>
    public class OapiProcessPrinterInstanceGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessPrinterInstanceGetResponse>
    {
        /// <summary>
        /// 脱敏数据请求
        /// </summary>
        public string Request { get; set; }

        public InstancePrintDataRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.printer.instance.get";
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
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// InstancePrintDataRequestDomain Data Structure.
/// </summary>
[Serializable]

public class InstancePrintDataRequestDomain : TopObject
{
	        /// <summary>
	        /// 微应用agentId
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 审批单实例编号
	        /// </summary>
	        [XmlElement("instance_id")]
	        public string InstanceId { get; set; }
	
	        /// <summary>
	        /// 流程code
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
}

        #endregion
    }
}
