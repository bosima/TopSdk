using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingpayBillBatchqueryResponse.
    /// </summary>
    public class OapiDingpayBillBatchqueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
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
        public BillBatchQueryOpenResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// DingPayBillOpenBoDomain Data Structure.
/// </summary>
[Serializable]

public class DingPayBillOpenBoDomain : TopObject
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
	        /// INCOME收入、EXPENSE支出
	        /// </summary>
	        [XmlElement("bill_category")]
	        public string BillCategory { get; set; }
	
	        /// <summary>
	        /// 账单号
	        /// </summary>
	        [XmlElement("bill_no")]
	        public string BillNo { get; set; }
	
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
	        /// 订单号
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
	        /// 收款方真实账号
	        /// </summary>
	        [XmlElement("pay_channel_payee_real_uid")]
	        public string PayChannelPayeeRealUid { get; set; }
	
	        /// <summary>
	        /// 支付渠道方付款者实际出资UID
	        /// </summary>
	        [XmlElement("pay_channel_payer_real_uid")]
	        public string PayChannelPayerRealUid { get; set; }
	
	        /// <summary>
	        /// 收款者corpId或者userId
	        /// </summary>
	        [XmlElement("payee_id")]
	        public string PayeeId { get; set; }
	
	        /// <summary>
	        /// 收款者类型
	        /// </summary>
	        [XmlElement("payee_user_type")]
	        public string PayeeUserType { get; set; }
	
	        /// <summary>
	        /// 付款者corpId或者userId
	        /// </summary>
	        [XmlElement("payer_id")]
	        public string PayerId { get; set; }
	
	        /// <summary>
	        /// 付款者类型
	        /// </summary>
	        [XmlElement("payer_user_type")]
	        public string PayerUserType { get; set; }
	
	        /// <summary>
	        /// 记账主体corpId或者userId
	        /// </summary>
	        [XmlElement("principal_id")]
	        public string PrincipalId { get; set; }
	
	        /// <summary>
	        /// 收款人账户类型
	        /// </summary>
	        [XmlElement("receiptor_type")]
	        public string ReceiptorType { get; set; }
	
	        /// <summary>
	        /// 来源应用ID
	        /// </summary>
	        [XmlElement("source_app_id")]
	        public string SourceAppId { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 中止操作员id
	        /// </summary>
	        [XmlElement("termination_operator_id")]
	        public string TerminationOperatorId { get; set; }
	
	        /// <summary>
	        /// 中止支付原因
	        /// </summary>
	        [XmlElement("termination_reason")]
	        public string TerminationReason { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// BillBatchQueryOpenResponseDomain Data Structure.
/// </summary>
[Serializable]

public class BillBatchQueryOpenResponseDomain : TopObject
{
	        /// <summary>
	        /// billList
	        /// </summary>
	        [XmlArray("bill_list")]
	        [XmlArrayItem("ding_pay_bill_open_bo")]
	        public List<DingPayBillOpenBoDomain> BillList { get; set; }
	
	        /// <summary>
	        /// 当前页码
	        /// </summary>
	        [XmlElement("current_page_num")]
	        public long CurrentPageNum { get; set; }
	
	        /// <summary>
	        /// 如果nextKey不为空，说明还有翻页数据
	        /// </summary>
	        [XmlElement("next_key")]
	        public string NextKey { get; set; }
	
	        /// <summary>
	        /// 每页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 总记录条数
	        /// </summary>
	        [XmlElement("total_count")]
	        public long TotalCount { get; set; }
	
	        /// <summary>
	        /// 总页数
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
}

    }
}
