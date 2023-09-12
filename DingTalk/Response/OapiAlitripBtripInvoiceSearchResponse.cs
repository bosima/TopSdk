using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripInvoiceSearchResponse.
    /// </summary>
    public class OapiAlitripBtripInvoiceSearchResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 发票列表
        /// </summary>
        [XmlArray("invoice")]
        [XmlArrayItem("open_invoice_do")]
        public List<OpenInvoiceDoDomain> Invoice { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenInvoiceDoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenInvoiceDoDomain : TopObject
{
	        /// <summary>
	        /// 商旅发票id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 第三方发票id
	        /// </summary>
	        [XmlElement("third_part_invoice_id")]
	        public string ThirdPartInvoiceId { get; set; }
	
	        /// <summary>
	        /// 发票抬头
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
