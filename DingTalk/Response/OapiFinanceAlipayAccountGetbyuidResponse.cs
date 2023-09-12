using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiFinanceAlipayAccountGetbyuidResponse.
    /// </summary>
    public class OapiFinanceAlipayAccountGetbyuidResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AlipayUserVoDomain Result { get; set; }

	/// <summary>
/// AlipayUserVoDomain Data Structure.
/// </summary>
[Serializable]

public class AlipayUserVoDomain : TopObject
{
	        /// <summary>
	        /// 用户支付宝uid
	        /// </summary>
	        [XmlElement("alipay_user_id")]
	        public string AlipayUserId { get; set; }
}

    }
}
