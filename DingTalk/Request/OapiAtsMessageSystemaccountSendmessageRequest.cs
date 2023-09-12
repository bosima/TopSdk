using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.message.systemaccount.sendmessage
    /// </summary>
    public class OapiAtsMessageSystemaccountSendmessageRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsMessageSystemaccountSendmessageResponse>
    {
        /// <summary>
        /// 模板内容value
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 消息模板code
        /// </summary>
        public string MessageBizCode { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string Openid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.message.systemaccount.sendmessage";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("content", this.Content);
            parameters.Add("message_biz_code", this.MessageBizCode);
            parameters.Add("openid", this.Openid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("content", this.Content);
            RequestValidator.ValidateRequired("message_biz_code", this.MessageBizCode);
            RequestValidator.ValidateRequired("openid", this.Openid);
        }

        #endregion
    }
}
