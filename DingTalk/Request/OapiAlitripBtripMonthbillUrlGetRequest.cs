using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.monthbill.url.get
    /// </summary>
    public class OapiAlitripBtripMonthbillUrlGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripMonthbillUrlGetResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Request { get; set; }

        public OpenAccountRqDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.monthbill.url.get";
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
/// OpenAccountRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenAccountRqDomain : TopObject
{
	        /// <summary>
	        /// 对账单月份，不传取最新对账单
	        /// </summary>
	        [XmlElement("bill_month")]
	        public string BillMonth { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
}

        #endregion
    }
}
