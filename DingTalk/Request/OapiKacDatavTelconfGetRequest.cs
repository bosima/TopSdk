using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.kac.datav.telconf.get
    /// </summary>
    public class OapiKacDatavTelconfGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiKacDatavTelconfGetResponse>
    {
        /// <summary>
        /// 请求参数对象
        /// </summary>
        public string Request { get; set; }

        public TelConferenceSummaryRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.kac.datav.telconf.get";
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
/// TelConferenceSummaryRequestDomain Data Structure.
/// </summary>
[Serializable]

public class TelConferenceSummaryRequestDomain : TopObject
{
	        /// <summary>
	        /// 日期标识
	        /// </summary>
	        [XmlElement("data_id")]
	        public string DataId { get; set; }
}

        #endregion
    }
}
