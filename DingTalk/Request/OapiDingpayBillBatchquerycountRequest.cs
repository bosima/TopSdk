using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingpay.bill.batchquerycount
    /// </summary>
    public class OapiDingpayBillBatchquerycountRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingpayBillBatchquerycountResponse>
    {
        /// <summary>
        /// 申请支付者userid
        /// </summary>
        public string ApplyPayOperatorUserid { get; set; }

        /// <summary>
        /// INCOME收入、EXPENSE支出
        /// </summary>
        public string BillCategory { get; set; }

        /// <summary>
        /// 业务代码
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 创单者userid
        /// </summary>
        public string CreateOperatorUserid { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// 申请付款开始时间
        /// </summary>
        public Nullable<DateTime> GmtApplyPayBeginTime { get; set; }

        /// <summary>
        /// 申请付款截止时间
        /// </summary>
        public Nullable<DateTime> GmtApplyPayEndTime { get; set; }

        /// <summary>
        /// 创单开始时间
        /// </summary>
        public Nullable<DateTime> GmtCreateBeginTime { get; set; }

        /// <summary>
        /// 创单截止时间
        /// </summary>
        public Nullable<DateTime> GmtCreateEndTime { get; set; }

        /// <summary>
        /// 完成付款开始时间
        /// </summary>
        public Nullable<DateTime> GmtPayBeginTime { get; set; }

        /// <summary>
        /// 完成付款截止时间
        /// </summary>
        public Nullable<DateTime> GmtPayEndTime { get; set; }

        /// <summary>
        /// 最大金额（单位：分）
        /// </summary>
        public Nullable<long> MaxAmount { get; set; }

        /// <summary>
        /// 最小金额（单位：分）
        /// </summary>
        public Nullable<long> MinAmount { get; set; }

        /// <summary>
        /// 支付渠道列表
        /// </summary>
        public string PayChannelList { get; set; }

        /// <summary>
        /// 支付渠道方付款者实际出资UID
        /// </summary>
        public string PayChannelPayerRealUid { get; set; }

        /// <summary>
        /// 收款者corpId或者userId
        /// </summary>
        public string PayeeId { get; set; }

        /// <summary>
        /// 收款者类型
        /// </summary>
        public string PayeeUserType { get; set; }

        /// <summary>
        /// 付款者corpId或者userId
        /// </summary>
        public string PayerId { get; set; }

        /// <summary>
        /// 付款者类型
        /// </summary>
        public string PayerUserType { get; set; }

        /// <summary>
        /// 收款人账户类型
        /// </summary>
        public string ReceiptorTypeList { get; set; }

        /// <summary>
        /// 状态列表
        /// </summary>
        public string StatusList { get; set; }

        /// <summary>
        /// 中止支付原因
        /// </summary>
        public string TerminationReason { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingpay.bill.batchquerycount";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("apply_pay_operator_userid", this.ApplyPayOperatorUserid);
            parameters.Add("bill_category", this.BillCategory);
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("create_operator_userid", this.CreateOperatorUserid);
            parameters.Add("extension", this.Extension);
            parameters.Add("gmt_apply_pay_begin_time", this.GmtApplyPayBeginTime);
            parameters.Add("gmt_apply_pay_end_time", this.GmtApplyPayEndTime);
            parameters.Add("gmt_create_begin_time", this.GmtCreateBeginTime);
            parameters.Add("gmt_create_end_time", this.GmtCreateEndTime);
            parameters.Add("gmt_pay_begin_time", this.GmtPayBeginTime);
            parameters.Add("gmt_pay_end_time", this.GmtPayEndTime);
            parameters.Add("max_amount", this.MaxAmount);
            parameters.Add("min_amount", this.MinAmount);
            parameters.Add("pay_channel_list", this.PayChannelList);
            parameters.Add("pay_channel_payer_real_uid", this.PayChannelPayerRealUid);
            parameters.Add("payee_id", this.PayeeId);
            parameters.Add("payee_user_type", this.PayeeUserType);
            parameters.Add("payer_id", this.PayerId);
            parameters.Add("payer_user_type", this.PayerUserType);
            parameters.Add("receiptor_type_list", this.ReceiptorTypeList);
            parameters.Add("status_list", this.StatusList);
            parameters.Add("termination_reason", this.TerminationReason);
            parameters.Add("title", this.Title);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("pay_channel_list", this.PayChannelList, 20);
            RequestValidator.ValidateMaxListSize("receiptor_type_list", this.ReceiptorTypeList, 20);
            RequestValidator.ValidateMaxListSize("status_list", this.StatusList, 20);
        }

        #endregion
    }
}
