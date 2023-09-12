using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.project.modify
    /// </summary>
    public class OapiAlitripBtripProjectModifyRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripProjectModifyResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Request { get; set; }

        public OpenProjectRsDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.project.modify";
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
/// OpenProjectRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenProjectRsDomain : TopObject
{
	        /// <summary>
	        /// 项目代码
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 项目名
	        /// </summary>
	        [XmlElement("project_name")]
	        public string ProjectName { get; set; }
	
	        /// <summary>
	        /// 第三方成本中心id
	        /// </summary>
	        [XmlElement("third_part_cost_center_id")]
	        public string ThirdPartCostCenterId { get; set; }
	
	        /// <summary>
	        /// 第三方项目id
	        /// </summary>
	        [XmlElement("third_part_id")]
	        public string ThirdPartId { get; set; }
	
	        /// <summary>
	        /// 第三方发票id
	        /// </summary>
	        [XmlElement("third_part_invoice_id")]
	        public string ThirdPartInvoiceId { get; set; }
}

        #endregion
    }
}
