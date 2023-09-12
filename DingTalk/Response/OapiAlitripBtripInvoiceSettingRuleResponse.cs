using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripInvoiceSettingRuleResponse.
    /// </summary>
    public class OapiAlitripBtripInvoiceSettingRuleResponse : DingTalkResponse
    {
        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("module")]
        public OpenInvoiceRuleRSDomain Module { get; set; }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenInvoiceRuleRSDomain Data Structure.
/// </summary>
[Serializable]

public class OpenInvoiceRuleRSDomain : TopObject
{
	        /// <summary>
	        /// 新增数
	        /// </summary>
	        [XmlElement("add_num")]
	        public long AddNum { get; set; }
	
	        /// <summary>
	        /// 删除数
	        /// </summary>
	        [XmlElement("remove_num")]
	        public long RemoveNum { get; set; }
}

    }
}
