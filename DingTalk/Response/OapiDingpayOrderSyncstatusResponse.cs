using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingpayOrderSyncstatusResponse.
    /// </summary>
    public class OapiDingpayOrderSyncstatusResponse : DingTalkResponse
    {
        /// <summary>
        /// 钉钉错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误文案
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public OrderSyncStatusOpenResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OrdersDomain Data Structure.
/// </summary>
[Serializable]

public class OrdersDomain : TopObject
{
	        /// <summary>
	        /// 金额（单位：分）
	        /// </summary>
	        [XmlElement("amount")]
	        public long Amount { get; set; }
	
	        /// <summary>
	        /// 发起支付操作员userId
	        /// </summary>
	        [XmlElement("apply_pay_operator_userid")]
	        public string ApplyPayOperatorUserid { get; set; }
	
	        /// <summary>
	        /// 业务代码
	        /// </summary>
	        [XmlElement("biz_code")]
	        public string BizCode { get; set; }
	
	        /// <summary>
	        /// 创单操作员userId
	        /// </summary>
	        [XmlElement("create_operator_userid")]
	        public string CreateOperatorUserid { get; set; }
	
	        /// <summary>
	        /// 扩展属性
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 申请支付时间
	        /// </summary>
	        [XmlElement("gmt_apply_pay")]
	        public string GmtApplyPay { get; set; }
	
	        /// <summary>
	        /// 创单时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 记录更新时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 完成付款时间
	        /// </summary>
	        [XmlElement("gmt_pay")]
	        public string GmtPay { get; set; }
	
	        /// <summary>
	        /// 钉支付订单号
	        /// </summary>
	        [XmlElement("order_no")]
	        public string OrderNo { get; set; }
	
	        /// <summary>
	        /// 外部流水号
	        /// </summary>
	        [XmlElement("out_biz_no")]
	        public string OutBizNo { get; set; }
	
	        /// <summary>
	        /// 支付渠道
	        /// </summary>
	        [XmlElement("pay_channel")]
	        public string PayChannel { get; set; }
	
	        /// <summary>
	        /// 支付渠道方流水号
	        /// </summary>
	        [XmlElement("pay_channel_biz_no")]
	        public string PayChannelBizNo { get; set; }
	
	        /// <summary>
	        /// 支付渠道方付款者UID
	        /// </summary>
	        [XmlElement("pay_channel_payer_real_uid")]
	        public string PayChannelPayerRealUid { get; set; }
	
	        /// <summary>
	        /// 收款方corpId或者userId
	        /// </summary>
	        [XmlElement("payee_id")]
	        public string PayeeId { get; set; }
	
	        /// <summary>
	        /// 收款方类型
	        /// </summary>
	        [XmlElement("payee_user_type")]
	        public string PayeeUserType { get; set; }
	
	        /// <summary>
	        /// 付款方corpId或者userId
	        /// </summary>
	        [XmlElement("payer_id")]
	        public string PayerId { get; set; }
	
	        /// <summary>
	        /// 付款方类型
	        /// </summary>
	        [XmlElement("payer_user_type")]
	        public string PayerUserType { get; set; }
	
	        /// <summary>
	        /// 来源应用ID
	        /// </summary>
	        [XmlElement("source_app_id")]
	        public string SourceAppId { get; set; }
	
	        /// <summary>
	        /// 订单状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// OrderSyncStatusOpenResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OrderSyncStatusOpenResponseDomain : TopObject
{
	        /// <summary>
	        /// orders
	        /// </summary>
	        [XmlArray("orders")]
	        [XmlArrayItem("orders")]
	        public List<OrdersDomain> Orders { get; set; }
}

    }
}
