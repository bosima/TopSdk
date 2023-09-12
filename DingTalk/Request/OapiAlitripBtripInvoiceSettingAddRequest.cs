using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.invoice.setting.add
    /// </summary>
    public class OapiAlitripBtripInvoiceSettingAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripInvoiceSettingAddResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Rq { get; set; }

        public OpenInvoiceModifyAndNewRqDomain Rq_ { set { this.Rq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.invoice.setting.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("rq", this.Rq);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("rq", this.Rq);
        }

	/// <summary>
/// OpenInvoiceModifyAndNewRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenInvoiceModifyAndNewRqDomain : TopObject
{
	        /// <summary>
	        /// 注册地址
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 开户行
	        /// </summary>
	        [XmlElement("bank_name")]
	        public string BankName { get; set; }
	
	        /// <summary>
	        /// 银行账号
	        /// </summary>
	        [XmlElement("bank_no")]
	        public string BankNo { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 税号
	        /// </summary>
	        [XmlElement("tax_no")]
	        public string TaxNo { get; set; }
	
	        /// <summary>
	        /// 公司电话
	        /// </summary>
	        [XmlElement("tel")]
	        public string Tel { get; set; }
	
	        /// <summary>
	        /// 第三方发票id
	        /// </summary>
	        [XmlElement("third_part_id")]
	        public string ThirdPartId { get; set; }
	
	        /// <summary>
	        /// 发票抬头
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 类型，1:增值税普通发票,2:增值税专用发票
	        /// </summary>
	        [XmlElement("type")]
	        public Nullable<long> Type { get; set; }
}

        #endregion
    }
}
