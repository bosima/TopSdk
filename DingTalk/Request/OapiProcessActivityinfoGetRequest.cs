using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.activityinfo.get
    /// </summary>
    public class OapiProcessActivityinfoGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessActivityinfoGetResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Request { get; set; }

        public ProcessQueryRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.activityinfo.get";
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
/// ProcessQueryRequestDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessQueryRequestDomain : TopObject
{
	        /// <summary>
	        /// 审批模板code
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
	
	        /// <summary>
	        /// 审批实例id
	        /// </summary>
	        [XmlElement("process_instance_id")]
	        public string ProcessInstanceId { get; set; }
}

        #endregion
    }
}
