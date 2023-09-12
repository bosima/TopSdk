using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingpayRedenvelopeGetResponse.
    /// </summary>
    public class OapiDingpayRedenvelopeGetResponse : DingTalkResponse
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
        /// 红包查询结果
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
	        /// 企业订单号，企业传入
	        /// </summary>
	        [XmlElement("corp_biz_no")]
	        public string CorpBizNo { get; set; }
	
	        /// <summary>
	        /// 红包祝福语
	        /// </summary>
	        [XmlElement("greetings")]
	        public string Greetings { get; set; }
	
	        /// <summary>
	        /// 红包订单号
	        /// </summary>
	        [XmlElement("order_no")]
	        public string OrderNo { get; set; }
	
	        /// <summary>
	        /// 红包领取金额
	        /// </summary>
	        [XmlElement("pick_amount")]
	        public string PickAmount { get; set; }
	
	        /// <summary>
	        /// 红包领取时间
	        /// </summary>
	        [XmlElement("pick_time")]
	        public string PickTime { get; set; }
	
	        /// <summary>
	        /// 红包接收人ID
	        /// </summary>
	        [XmlElement("receiver_id")]
	        public string ReceiverId { get; set; }
	
	        /// <summary>
	        /// 红包退款金额
	        /// </summary>
	        [XmlElement("refund_amount")]
	        public string RefundAmount { get; set; }
	
	        /// <summary>
	        /// 红包退款时间
	        /// </summary>
	        [XmlElement("refund_time")]
	        public string RefundTime { get; set; }
	
	        /// <summary>
	        /// 红包发送时间
	        /// </summary>
	        [XmlElement("send_time")]
	        public string SendTime { get; set; }
	
	        /// <summary>
	        /// 红包发送人ID，当红包类型为SINGLE_QUOTA时有值
	        /// </summary>
	        [XmlElement("sender_id")]
	        public string SenderId { get; set; }
	
	        /// <summary>
	        /// 红包状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 红包主题ID
	        /// </summary>
	        [XmlElement("theme_id")]
	        public string ThemeId { get; set; }
	
	        /// <summary>
	        /// 红包金额
	        /// </summary>
	        [XmlElement("total_amount")]
	        public string TotalAmount { get; set; }
	
	        /// <summary>
	        /// 红包类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

    }
}
