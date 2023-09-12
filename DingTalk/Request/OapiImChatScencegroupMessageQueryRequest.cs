using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.scencegroup.message.query
    /// </summary>
    public class OapiImChatScencegroupMessageQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatScencegroupMessageQueryResponse>
    {
        /// <summary>
        /// 群标识
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 消息标识
        /// </summary>
        public string OpenMsgId { get; set; }

        /// <summary>
        /// 消息发送人的unionId（跟userId二选一）
        /// </summary>
        public string SenderUnionId { get; set; }

        /// <summary>
        /// 消息发送人的userId（跟unionId二选一）
        /// </summary>
        public string SenderUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.scencegroup.message.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("open_msg_id", this.OpenMsgId);
            parameters.Add("sender_union_id", this.SenderUnionId);
            parameters.Add("sender_userid", this.SenderUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("open_conversation_id", this.OpenConversationId);
            RequestValidator.ValidateRequired("open_msg_id", this.OpenMsgId);
        }

        #endregion
    }
}
