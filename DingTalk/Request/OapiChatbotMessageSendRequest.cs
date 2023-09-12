using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chatbot.message.send
    /// </summary>
    public class OapiChatbotMessageSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatbotMessageSendResponse>
    {
        /// <summary>
        /// 企业机器人模板类型
        /// </summary>
        public string ChatbotId { get; set; }

        /// <summary>
        /// 消息内容,支持的消息类型详见：https://open-doc.dingtalk.com/microapp/serverapi2/qf2nxq#a-namesgw3aga%E6%B6%88%E6%81%AF%E7%B1%BB%E5%9E%8B%E5%8F%8A%E6%95%B0%E6%8D%AE%E6%A0%BC%E5%BC%8F
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 企业员工ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chatbot.message.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatbot_id", this.ChatbotId);
            parameters.Add("message", this.Message);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatbot_id", this.ChatbotId);
            RequestValidator.ValidateRequired("message", this.Message);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
