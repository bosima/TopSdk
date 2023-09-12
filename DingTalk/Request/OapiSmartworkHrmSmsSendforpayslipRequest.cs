using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.sms.sendforpayslip
    /// </summary>
    public class OapiSmartworkHrmSmsSendforpayslipRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmSmsSendforpayslipResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Param { get; set; }

        public PayslipSmsMessageParamDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.sms.sendforpayslip";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param", this.Param);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("param", this.Param);
        }

	/// <summary>
/// PayslipSmsMessageParamDomain Data Structure.
/// </summary>
[Serializable]

public class PayslipSmsMessageParamDomain : TopObject
{
	        /// <summary>
	        /// 工资条月份
	        /// </summary>
	        [XmlElement("month")]
	        public Nullable<long> Month { get; set; }
	
	        /// <summary>
	        /// 员工userids
	        /// </summary>
	        [XmlArray("userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> UseridList { get; set; }
}

        #endregion
    }
}
