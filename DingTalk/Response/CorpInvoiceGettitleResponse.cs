using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpInvoiceGettitleResponse.
    /// </summary>
    public class CorpInvoiceGettitleResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// InvoiceVoDomain Data Structure.
/// </summary>
[Serializable]

public class InvoiceVoDomain : TopObject
{
	        /// <summary>
	        /// 银行账户
	        /// </summary>
	        [XmlElement("account")]
	        public string Account { get; set; }
	
	        /// <summary>
	        /// 企业注册地址
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 开户行
	        /// </summary>
	        [XmlElement("bank_name")]
	        public string BankName { get; set; }
	
	        /// <summary>
	        /// 联系方式
	        /// </summary>
	        [XmlElement("contact")]
	        public string Contact { get; set; }
	
	        /// <summary>
	        /// 税号
	        /// </summary>
	        [XmlElement("duty_para")]
	        public string DutyPara { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 发票抬头
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlElement("invoice")]
	        public InvoiceVoDomain Invoice { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
