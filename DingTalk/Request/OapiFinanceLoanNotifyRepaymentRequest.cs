using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.finance.loan.notify.repayment
    /// </summary>
    public class OapiFinanceLoanNotifyRepaymentRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiFinanceLoanNotifyRepaymentResponse>
    {
        /// <summary>
        /// 授信额度(单位：分)，授信成功必需
        /// </summary>
        public Nullable<long> Amount { get; set; }

        /// <summary>
        /// 可用授信额度：等于授信总额度减去已经借款总额度
        /// </summary>
        public Nullable<long> AvailableAmount { get; set; }

        /// <summary>
        /// 还款银行名称
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// 还款银行卡号
        /// </summary>
        public string BankcardNo { get; set; }

        /// <summary>
        /// 本次还款时利息逾期天数(不包括已经还逾期的，没有则为0)：多笔分期还款逾期，求各逾期天数总和；如：1期逾期35天，第2期逾期4天，总逾期39天
        /// </summary>
        public Nullable<long> CurrentIntOvdDays { get; set; }

        /// <summary>
        /// 本次还款时逾期期次(不包括已经还的逾期，没有则为0)：如1,2=第1期+第2期都逾期
        /// </summary>
        public string CurrentOvdTerms { get; set; }

        /// <summary>
        /// 本次已还利息(单位：分)
        /// </summary>
        public Nullable<long> CurrentPaidInterest { get; set; }

        /// <summary>
        /// 本次已还罚息(单位：分，精确2位小数，没有则为0)=本次本金罚息+本次利息罚息
        /// </summary>
        public Nullable<long> CurrentPaidPenalty { get; set; }

        /// <summary>
        /// 本次已还本金(单位：分)
        /// </summary>
        public Nullable<long> CurrentPaidPrincipal { get; set; }

        /// <summary>
        /// 本次已还总金额(单位：分)：已还本金+已还利息+已还罚息
        /// </summary>
        public Nullable<long> CurrentPaidTotalAmount { get; set; }

        /// <summary>
        /// 本次还款时本金逾期天数(不包括已经还逾期的，没有则为0)：多笔分期还款逾期，求各逾期天数总和；如：1期逾期35天，第2期逾期4天，总逾期39天
        /// </summary>
        public Nullable<long> CurrentPrinOvdDays { get; set; }

        /// <summary>
        /// 还款结果信息：失败原因等
        /// </summary>
        public string FailReason { get; set; }

        /// <summary>
        /// 还款失败原因(还款失败必传)：用户发送钉钉卡片消息
        /// </summary>
        public string FailReasonToUser { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCardNo { get; set; }

        /// <summary>
        /// 借据编号
        /// </summary>
        public string LoanOrderNo { get; set; }

        /// <summary>
        /// 渠道方名称
        /// </summary>
        public string OpenChannelName { get; set; }

        /// <summary>
        /// 渠道方产品码
        /// </summary>
        public string OpenProductCode { get; set; }

        /// <summary>
        /// 渠道方产品名称
        /// </summary>
        public string OpenProductName { get; set; }

        /// <summary>
        /// 渠道方产品类型
        /// </summary>
        public string OpenProductType { get; set; }

        /// <summary>
        /// 已还利息(单位：分)
        /// </summary>
        public Nullable<long> PaidInterest { get; set; }

        /// <summary>
        /// 已还罚息(单位：分，没有则为0)=本金罚息+利息罚息
        /// </summary>
        public Nullable<long> PaidPenalty { get; set; }

        /// <summary>
        /// 已还本金(单位：分)
        /// </summary>
        public Nullable<long> PaidPrincipal { get; set; }

        /// <summary>
        /// 已还总金额(单位：分)：已还本金+已还利息+已还罚息
        /// </summary>
        public Nullable<long> PaidTotalAmount { get; set; }

        /// <summary>
        /// 应还利息(单位：分)
        /// </summary>
        public Nullable<long> PayableInterest { get; set; }

        /// <summary>
        /// 应还罚息(单位：分，没有则为0)=本金罚息+利息罚息
        /// </summary>
        public Nullable<long> PayablePenalty { get; set; }

        /// <summary>
        /// 应还本金(单位：分)
        /// </summary>
        public Nullable<long> PayablePrincipal { get; set; }

        /// <summary>
        /// 应还总金额(单位：分)：应还本金+应还利息+应还罚息
        /// </summary>
        public Nullable<long> PayableTotalAmount { get; set; }

        /// <summary>
        /// 该期次是否已经全部还清：0 没有还清，1 全部还清
        /// </summary>
        public Nullable<long> PeriodPaidAll { get; set; }

        /// <summary>
        /// 该期次已还利息(单位：分)
        /// </summary>
        public Nullable<long> PeriodPaidInterest { get; set; }

        /// <summary>
        /// 该期次已还罚息(单位：分，精确2位小数，没有则为0)=该期次本金罚息+该期次利息罚息
        /// </summary>
        public Nullable<long> PeriodPaidPenalty { get; set; }

        /// <summary>
        /// 该期次已还本金(单位：分)
        /// </summary>
        public Nullable<long> PeriodPaidPrincipal { get; set; }

        /// <summary>
        /// 该期次已还总金额(单位：分)
        /// </summary>
        public Nullable<long> PeriodPaidTotalAmount { get; set; }

        /// <summary>
        /// 该期次应还利息(单位：分)
        /// </summary>
        public Nullable<long> PeriodPayableInterest { get; set; }

        /// <summary>
        /// 该期次应还罚息(单位：分，没有则为0)
        /// </summary>
        public Nullable<long> PeriodPayablePenalty { get; set; }

        /// <summary>
        /// 该期次应还本金(单位：分)
        /// </summary>
        public Nullable<long> PeriodPayablePrincipal { get; set; }

        /// <summary>
        /// 该期次应还总金额(单位：分)：应还本金+应还利息+应还罚息
        /// </summary>
        public Nullable<long> PeriodPayableTotalAmount { get; set; }

        /// <summary>
        /// 还款时间
        /// </summary>
        public string RepayRealDate { get; set; }

        /// <summary>
        /// 还款方式：RMT00 等额本息，RMT01 先息后本
        /// </summary>
        public string RepayType { get; set; }

        /// <summary>
        /// 还款编号：当前渠道唯一，用于处理重复通知问题
        /// </summary>
        public string RepaymentNo { get; set; }

        /// <summary>
        /// 还款期次：1=第1期
        /// </summary>
        public string RepaymentTerms { get; set; }

        /// <summary>
        /// 还款状态：SUCCESS=成功、FAIL=失败、PING=还款中
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 还款类型：SYSTERM=系统代扣、ONTIME=按期还款、ADVANCE=提前还款、OVERDUE=逾期还款
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string UserMobile { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.finance.loan.notify.repayment";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("amount", this.Amount);
            parameters.Add("available_amount", this.AvailableAmount);
            parameters.Add("bank_name", this.BankName);
            parameters.Add("bankcard_no", this.BankcardNo);
            parameters.Add("current_int_ovd_days", this.CurrentIntOvdDays);
            parameters.Add("current_ovd_terms", this.CurrentOvdTerms);
            parameters.Add("current_paid_interest", this.CurrentPaidInterest);
            parameters.Add("current_paid_penalty", this.CurrentPaidPenalty);
            parameters.Add("current_paid_principal", this.CurrentPaidPrincipal);
            parameters.Add("current_paid_total_amount", this.CurrentPaidTotalAmount);
            parameters.Add("current_prin_ovd_days", this.CurrentPrinOvdDays);
            parameters.Add("fail_reason", this.FailReason);
            parameters.Add("fail_reason_to_user", this.FailReasonToUser);
            parameters.Add("id_card_no", this.IdCardNo);
            parameters.Add("loan_order_no", this.LoanOrderNo);
            parameters.Add("open_channel_name", this.OpenChannelName);
            parameters.Add("open_product_code", this.OpenProductCode);
            parameters.Add("open_product_name", this.OpenProductName);
            parameters.Add("open_product_type", this.OpenProductType);
            parameters.Add("paid_interest", this.PaidInterest);
            parameters.Add("paid_penalty", this.PaidPenalty);
            parameters.Add("paid_principal", this.PaidPrincipal);
            parameters.Add("paid_total_amount", this.PaidTotalAmount);
            parameters.Add("payable_interest", this.PayableInterest);
            parameters.Add("payable_penalty", this.PayablePenalty);
            parameters.Add("payable_principal", this.PayablePrincipal);
            parameters.Add("payable_total_amount", this.PayableTotalAmount);
            parameters.Add("period_paid_all", this.PeriodPaidAll);
            parameters.Add("period_paid_interest", this.PeriodPaidInterest);
            parameters.Add("period_paid_penalty", this.PeriodPaidPenalty);
            parameters.Add("period_paid_principal", this.PeriodPaidPrincipal);
            parameters.Add("period_paid_total_amount", this.PeriodPaidTotalAmount);
            parameters.Add("period_payable_interest", this.PeriodPayableInterest);
            parameters.Add("period_payable_penalty", this.PeriodPayablePenalty);
            parameters.Add("period_payable_principal", this.PeriodPayablePrincipal);
            parameters.Add("period_payable_total_amount", this.PeriodPayableTotalAmount);
            parameters.Add("repay_real_date", this.RepayRealDate);
            parameters.Add("repay_type", this.RepayType);
            parameters.Add("repayment_no", this.RepaymentNo);
            parameters.Add("repayment_terms", this.RepaymentTerms);
            parameters.Add("status", this.Status);
            parameters.Add("type", this.Type);
            parameters.Add("user_mobile", this.UserMobile);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("amount", this.Amount);
            RequestValidator.ValidateRequired("available_amount", this.AvailableAmount);
            RequestValidator.ValidateRequired("bank_name", this.BankName);
            RequestValidator.ValidateRequired("bankcard_no", this.BankcardNo);
            RequestValidator.ValidateRequired("current_int_ovd_days", this.CurrentIntOvdDays);
            RequestValidator.ValidateRequired("current_ovd_terms", this.CurrentOvdTerms);
            RequestValidator.ValidateRequired("current_paid_interest", this.CurrentPaidInterest);
            RequestValidator.ValidateRequired("current_paid_penalty", this.CurrentPaidPenalty);
            RequestValidator.ValidateRequired("current_paid_principal", this.CurrentPaidPrincipal);
            RequestValidator.ValidateRequired("current_paid_total_amount", this.CurrentPaidTotalAmount);
            RequestValidator.ValidateRequired("current_prin_ovd_days", this.CurrentPrinOvdDays);
            RequestValidator.ValidateRequired("fail_reason", this.FailReason);
            RequestValidator.ValidateRequired("fail_reason_to_user", this.FailReasonToUser);
            RequestValidator.ValidateRequired("id_card_no", this.IdCardNo);
            RequestValidator.ValidateRequired("loan_order_no", this.LoanOrderNo);
            RequestValidator.ValidateRequired("open_channel_name", this.OpenChannelName);
            RequestValidator.ValidateRequired("open_product_code", this.OpenProductCode);
            RequestValidator.ValidateRequired("open_product_name", this.OpenProductName);
            RequestValidator.ValidateRequired("open_product_type", this.OpenProductType);
            RequestValidator.ValidateRequired("paid_interest", this.PaidInterest);
            RequestValidator.ValidateRequired("paid_penalty", this.PaidPenalty);
            RequestValidator.ValidateRequired("paid_principal", this.PaidPrincipal);
            RequestValidator.ValidateRequired("paid_total_amount", this.PaidTotalAmount);
            RequestValidator.ValidateRequired("payable_interest", this.PayableInterest);
            RequestValidator.ValidateRequired("payable_penalty", this.PayablePenalty);
            RequestValidator.ValidateRequired("payable_principal", this.PayablePrincipal);
            RequestValidator.ValidateRequired("payable_total_amount", this.PayableTotalAmount);
            RequestValidator.ValidateRequired("period_paid_all", this.PeriodPaidAll);
            RequestValidator.ValidateRequired("period_paid_interest", this.PeriodPaidInterest);
            RequestValidator.ValidateRequired("period_paid_penalty", this.PeriodPaidPenalty);
            RequestValidator.ValidateRequired("period_paid_principal", this.PeriodPaidPrincipal);
            RequestValidator.ValidateRequired("period_paid_total_amount", this.PeriodPaidTotalAmount);
            RequestValidator.ValidateRequired("period_payable_interest", this.PeriodPayableInterest);
            RequestValidator.ValidateRequired("period_payable_penalty", this.PeriodPayablePenalty);
            RequestValidator.ValidateRequired("period_payable_principal", this.PeriodPayablePrincipal);
            RequestValidator.ValidateRequired("period_payable_total_amount", this.PeriodPayableTotalAmount);
            RequestValidator.ValidateRequired("repay_real_date", this.RepayRealDate);
            RequestValidator.ValidateRequired("repay_type", this.RepayType);
            RequestValidator.ValidateRequired("repayment_no", this.RepaymentNo);
            RequestValidator.ValidateRequired("repayment_terms", this.RepaymentTerms);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateRequired("user_mobile", this.UserMobile);
        }

        #endregion
    }
}
