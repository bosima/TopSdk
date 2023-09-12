using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.newretail.sendstaffgroupmessage
    /// </summary>
    public class OapiImpaasNewretailSendstaffgroupmessageRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasNewretailSendstaffgroupmessageResponse>
    {
        /// <summary>
        /// 加密后的群号
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public Nullable<long> MsgType { get; set; }

        /// <summary>
        /// 系统账号名
        /// </summary>
        public string Sender { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.newretail.sendstaffgroupmessage";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chat_id", this.ChatId);
            parameters.Add("content", this.Content);
            parameters.Add("msg_type", this.MsgType);
            parameters.Add("sender", this.Sender);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
