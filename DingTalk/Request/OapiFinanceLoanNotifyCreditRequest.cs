using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.finance.loan.notify.credit
    /// </summary>
    public class OapiFinanceLoanNotifyCreditRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiFinanceLoanNotifyCreditResponse>
    {
        /// <summary>
        /// 授信额度(单位：分)，授信成功必需
        /// </summary>
        public Nullable<long> Amount { get; set; }

        /// <summary>
        /// 可用授信额度
        /// </summary>
        public Nullable<long> AvailableAmount { get; set; }

        /// <summary>
        /// 授信金额变化值： 等于0(默认) 不变，大于0 增加，小于0 减少
        /// </summary>
        public Nullable<long> ChangeAmount { get; set; }

        /// <summary>
        /// 授信完成时间
        /// </summary>
        public string CompleteTime { get; set; }

        /// <summary>
        /// 授信编号
        /// </summary>
        public string CreditNo { get; set; }

        /// <summary>
        /// 授信类型：null或0(默认) 授信额度无变化，1 授信额度有变化，变化值见changeAmount
        /// </summary>
        public Nullable<long> CreditType { get; set; }

        /// <summary>
        /// 日利率(精确4位小数，百分之*)，样例：0.0125
        /// </summary>
        public string DailyInterestRate { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCardNo { get; set; }

        /// <summary>
        /// 下一次申请日期
        /// </summary>
        public string NextApplyDay { get; set; }

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
        /// 拒绝原因错误码，授信失败必需
        /// </summary>
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝原因，授信失败必需
        /// </summary>
        public string RefuseReason { get; set; }

        /// <summary>
        /// 授信结果：0 未提交，1 授信申请中，2 授信成功/审批通过，3 授信失败/审批拒绝
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 授信提交/申请时间
        /// </summary>
        public string SubmitTime { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string UserMobile { get; set; }

        /// <summary>
        /// 年利率(精确2位小数，百分之*)，样例：5.45
        /// </summary>
        public string YearInterestRate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.finance.loan.notify.credit";
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
            parameters.Add("change_amount", this.ChangeAmount);
            parameters.Add("complete_time", this.CompleteTime);
            parameters.Add("credit_no", this.CreditNo);
            parameters.Add("credit_type", this.CreditType);
            parameters.Add("daily_interest_rate", this.DailyInterestRate);
            parameters.Add("extension", this.Extension);
            parameters.Add("id_card_no", this.IdCardNo);
            parameters.Add("next_apply_day", this.NextApplyDay);
            parameters.Add("open_channel_name", this.OpenChannelName);
            parameters.Add("open_product_code", this.OpenProductCode);
            parameters.Add("open_product_name", this.OpenProductName);
            parameters.Add("open_product_type", this.OpenProductType);
            parameters.Add("refuse_code", this.RefuseCode);
            parameters.Add("refuse_reason", this.RefuseReason);
            parameters.Add("status", this.Status);
            parameters.Add("submit_time", this.SubmitTime);
            parameters.Add("user_mobile", this.UserMobile);
            parameters.Add("year_interest_rate", this.YearInterestRate);
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
            RequestValidator.ValidateRequired("change_amount", this.ChangeAmount);
            RequestValidator.ValidateRequired("complete_time", this.CompleteTime);
            RequestValidator.ValidateRequired("credit_no", this.CreditNo);
            RequestValidator.ValidateRequired("credit_type", this.CreditType);
            RequestValidator.ValidateRequired("daily_interest_rate", this.DailyInterestRate);
            RequestValidator.ValidateRequired("id_card_no", this.IdCardNo);
            RequestValidator.ValidateRequired("next_apply_day", this.NextApplyDay);
            RequestValidator.ValidateRequired("open_channel_name", this.OpenChannelName);
            RequestValidator.ValidateRequired("open_product_code", this.OpenProductCode);
            RequestValidator.ValidateRequired("open_product_name", this.OpenProductName);
            RequestValidator.ValidateRequired("open_product_type", this.OpenProductType);
            RequestValidator.ValidateRequired("refuse_code", this.RefuseCode);
            RequestValidator.ValidateRequired("refuse_reason", this.RefuseReason);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateRequired("submit_time", this.SubmitTime);
            RequestValidator.ValidateRequired("user_mobile", this.UserMobile);
            RequestValidator.ValidateRequired("year_interest_rate", this.YearInterestRate);
        }

        #endregion
    }
}
