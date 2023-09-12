using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.employee.listbycert
    /// </summary>
    public class OapiSmartworkHrmEmployeeListbycertRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmEmployeeListbycertResponse>
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public string Params { get; set; }

        public List<NameAndCertNumberQueryParamDomain> Params_ { set { this.Params = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.employee.listbycert";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("params", this.Params);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("params", this.Params);
            RequestValidator.ValidateObjectMaxListSize("params", this.Params, 100);
        }

	/// <summary>
/// NameAndCertNumberQueryParamDomain Data Structure.
/// </summary>
[Serializable]

public class NameAndCertNumberQueryParamDomain : TopObject
{
	        /// <summary>
	        /// 身份证号
	        /// </summary>
	        [XmlElement("cert_no")]
	        public string CertNo { get; set; }
	
	        /// <summary>
	        /// 姓名
	        /// </summary>
	        [XmlElement("real_name")]
	        public string RealName { get; set; }
}

        #endregion
    }
}
