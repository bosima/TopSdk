using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAppstoreInternalOrderGetResponse.
    /// </summary>
    public class OapiAppstoreInternalOrderGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 服务调用成功
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 服务调用成功
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("result")]
        public InAppGoodsOrderVoDomain Result { get; set; }

	/// <summary>
/// InAppGoodsOrderVoDomain Data Structure.
/// </summary>
[Serializable]

public class InAppGoodsOrderVoDomain : TopObject
{
	        /// <summary>
	        /// 内购商品订单号
	        /// </summary>
	        [XmlElement("biz_order_id")]
	        public long BizOrderId { get; set; }
	
	        /// <summary>
	        /// 购买商品的企业开放Id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 订单创建时间
	        /// </summary>
	        [XmlElement("create_timestamp")]
	        public long CreateTimestamp { get; set; }
	
	        /// <summary>
	        /// 订购的服务结束时间
	        /// </summary>
	        [XmlElement("end_timestamp")]
	        public long EndTimestamp { get; set; }
	
	        /// <summary>
	        /// 内购商品码
	        /// </summary>
	        [XmlElement("goods_code")]
	        public string GoodsCode { get; set; }
	
	        /// <summary>
	        /// 内购商品规格码
	        /// </summary>
	        [XmlElement("item_code")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 订单支付时间
	        /// </summary>
	        [XmlElement("paid_timestamp")]
	        public long PaidTimestamp { get; set; }
	
	        /// <summary>
	        /// 订购数量，周期型商品此字段为空
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
	
	        /// <summary>
	        /// 订购的服务开始时间
	        /// </summary>
	        [XmlElement("start_timestamp")]
	        public long StartTimestamp { get; set; }
	
	        /// <summary>
	        /// 订单状态，0 - 订单关闭，3 - 订单支付，4 - 订单创建
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 实际支付总金额，单位为分(RMB)
	        /// </summary>
	        [XmlElement("total_actual_pay_fee")]
	        public long TotalActualPayFee { get; set; }
}

    }
}
