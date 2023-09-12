using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAppstoreInternalUnfinishedorderListResponse.
    /// </summary>
    public class OapiAppstoreInternalUnfinishedorderListResponse : DingTalkResponse
    {
        /// <summary>
        /// 服务结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 服务结果描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 查询结果
        /// </summary>
        [XmlElement("result")]
        public PageModelDomain Result { get; set; }

	/// <summary>
/// InAppGoodsOrderVODomain Data Structure.
/// </summary>
[Serializable]

public class InAppGoodsOrderVODomain : TopObject
{
	        /// <summary>
	        /// 订单号
	        /// </summary>
	        [XmlElement("biz_order_id")]
	        public long BizOrderId { get; set; }
	
	        /// <summary>
	        /// 购买商品的企业开放Id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 订单创建时间戳
	        /// </summary>
	        [XmlElement("create_timestamp")]
	        public long CreateTimestamp { get; set; }
	
	        /// <summary>
	        /// 商品码
	        /// </summary>
	        [XmlElement("goods_code")]
	        public string GoodsCode { get; set; }
	
	        /// <summary>
	        /// 内购商品规格码
	        /// </summary>
	        [XmlElement("item_code")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 订单支付时间戳
	        /// </summary>
	        [XmlElement("paid_timestamp")]
	        public long PaidTimestamp { get; set; }
	
	        /// <summary>
	        /// 订购数量，周期型商品该字段为空
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
	
	        /// <summary>
	        /// 订单状态，3 - 已支付状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 实际支付总金额，CNY(分)
	        /// </summary>
	        [XmlElement("total_actual_pay_fee")]
	        public long TotalActualPayFee { get; set; }
}

	/// <summary>
/// PageModelDomain Data Structure.
/// </summary>
[Serializable]

public class PageModelDomain : TopObject
{
	        /// <summary>
	        /// 订单信息列表
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("in_app_goods_order_v_o")]
	        public List<InAppGoodsOrderVODomain> Items { get; set; }
	
	        /// <summary>
	        /// 总记录数
	        /// </summary>
	        [XmlElement("total")]
	        public long Total { get; set; }
}

    }
}
