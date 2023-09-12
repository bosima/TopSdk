using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.kac.datav.ding.get
    /// </summary>
    public class OapiKacDatavDingGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiKacDatavDingGetResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string DingUsageSummaryRequest { get; set; }

        public DingUsageSummaryRequestDomain DingUsageSummaryRequest_ { set { this.DingUsageSummaryRequest = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.kac.datav.ding.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ding_usage_summary_request", this.DingUsageSummaryRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ding_usage_summary_request", this.DingUsageSummaryRequest);
        }

	/// <summary>
/// DingUsageSummaryRequestDomain Data Structure.
/// </summary>
[Serializable]

public class DingUsageSummaryRequestDomain : TopObject
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
