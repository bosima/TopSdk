using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingpayVirtualaccountQueryResponse.
    /// </summary>
    public class OapiDingpayVirtualaccountQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 钉钉错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误详情
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AccountQueryOpenResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// DingPayAccountOpenBoDomain Data Structure.
/// </summary>
[Serializable]

public class DingPayAccountOpenBoDomain : TopObject
{
	        /// <summary>
	        /// 支付宝托管账户
	        /// </summary>
	        [XmlElement("anonymous_alipay_uid")]
	        public string AnonymousAlipayUid { get; set; }
	
	        /// <summary>
	        /// 企业corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 扩展属性
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 支付宝资金账号列表
	        /// </summary>
	        [XmlArray("real_alipay_uids")]
	        [XmlArrayItem("string")]
	        public List<string> RealAlipayUids { get; set; }
	
	        /// <summary>
	        /// 当前使用的支付宝资金账号
	        /// </summary>
	        [XmlElement("real_used_alipay_uid")]
	        public string RealUsedAlipayUid { get; set; }
}

	/// <summary>
/// AccountQueryOpenResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AccountQueryOpenResponseDomain : TopObject
{
	        /// <summary>
	        /// accountOpenBO
	        /// </summary>
	        [XmlElement("account_open_bo")]
	        public DingPayAccountOpenBoDomain AccountOpenBo { get; set; }
}

    }
}
