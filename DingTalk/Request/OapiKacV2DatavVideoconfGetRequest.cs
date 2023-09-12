using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.kac.v2.datav.videoconf.get
    /// </summary>
    public class OapiKacV2DatavVideoconfGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiKacV2DatavVideoconfGetResponse>
    {
        /// <summary>
        /// 请求对象类型
        /// </summary>
        public string Request { get; set; }

        public McsSummaryRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.kac.v2.datav.videoconf.get";
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
/// McsSummaryRequestDomain Data Structure.
/// </summary>
[Serializable]

public class McsSummaryRequestDomain : TopObject
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
