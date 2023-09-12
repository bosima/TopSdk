using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingpay.redenvelope.send
    /// </summary>
    public class OapiDingpayRedenvelopeSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingpayRedenvelopeSendResponse>
    {
        /// <summary>
        /// 群会话ID
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// 企业业务订单号（每个订单号必须唯一。取值范围：0~9，a~z，A~Z），接口根据企业订单号支持幂等，组成参考：corp_id+yyyymmdd+10位一天内不能重复的数字
        /// </summary>
        public string CorpBizNo { get; set; }

        /// <summary>
        /// 额外参数
        /// </summary>
        public string ExtParams { get; set; }

        /// <summary>
        /// 红包祝福语
        /// </summary>
        public string Greetings { get; set; }

        /// <summary>
        /// 群会话ID
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 支付方式，WITHHOLD：代扣模式，目前只支持该方式
        /// </summary>
        public string PayMethod { get; set; }

        /// <summary>
        /// 签名方式咨询技术支持
        /// </summary>
        public string PaySign { get; set; }

        /// <summary>
        /// 接收人ID
        /// </summary>
        public string ReceiverId { get; set; }

        /// <summary>
        /// 发送人ID
        /// </summary>
        public string SenderId { get; set; }

        /// <summary>
        /// 红包主题ID
        /// </summary>
        public string ThemeId { get; set; }

        /// <summary>
        /// 红包金额
        /// </summary>
        public string TotalAmount { get; set; }

        /// <summary>
        /// 红包类型，目前支持：SINGLE_QUOTA，个人单聊红包
        /// </summary>
        public string Type { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingpay.redenvelope.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chat_id", this.ChatId);
            parameters.Add("corp_biz_no", this.CorpBizNo);
            parameters.Add("ext_params", this.ExtParams);
            parameters.Add("greetings", this.Greetings);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("pay_method", this.PayMethod);
            parameters.Add("pay_sign", this.PaySign);
            parameters.Add("receiver_id", this.ReceiverId);
            parameters.Add("sender_id", this.SenderId);
            parameters.Add("theme_id", this.ThemeId);
            parameters.Add("total_amount", this.TotalAmount);
            parameters.Add("type", this.Type);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("corp_biz_no", this.CorpBizNo);
            RequestValidator.ValidateRequired("pay_method", this.PayMethod);
            RequestValidator.ValidateRequired("pay_sign", this.PaySign);
            RequestValidator.ValidateRequired("receiver_id", this.ReceiverId);
            RequestValidator.ValidateRequired("total_amount", this.TotalAmount);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion
    }
}
