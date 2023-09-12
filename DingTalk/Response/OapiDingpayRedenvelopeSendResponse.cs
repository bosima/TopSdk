using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingpayRedenvelopeSendResponse.
    /// </summary>
    public class OapiDingpayRedenvelopeSendResponse : DingTalkResponse
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
        /// 红包发送结果
        /// </summary>
        [XmlElement("result")]
        public RedEnvelopeGetResultDomain Result { get; set; }

	/// <summary>
/// RedEnvelopeGetResultDomain Data Structure.
/// </summary>
[Serializable]

public class RedEnvelopeGetResultDomain : TopObject
{
	        /// <summary>
	        /// 企业订单号
	        /// </summary>
	        [XmlElement("corp_biz_no")]
	        public string CorpBizNo { get; set; }
	
	        /// <summary>
	        /// 订单订单号
	        /// </summary>
	        [XmlElement("order_no")]
	        public string OrderNo { get; set; }
}

    }
}
