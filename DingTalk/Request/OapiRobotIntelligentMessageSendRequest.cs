using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.robot.intelligent.message.send
    /// </summary>
    public class OapiRobotIntelligentMessageSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRobotIntelligentMessageSendResponse>
    {
        /// <summary>
        /// at人的unionId列表
        /// </summary>
        public string AtUnionIds { get; set; }

        /// <summary>
        /// 申请到的消息模板唯一标识符
        /// </summary>
        public string MsgKey { get; set; }

        /// <summary>
        /// 消息模板中，变量本次替换的值
        /// </summary>
        public string MsgParam { get; set; }

        /// <summary>
        /// 开放的群ID
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 消息接收者的unionId列表，如果不传则表示群全员可见
        /// </summary>
        public string ReceiverUnionIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.robot.intelligent.message.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("at_union_ids", this.AtUnionIds);
            parameters.Add("msg_key", this.MsgKey);
            parameters.Add("msg_param", this.MsgParam);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("receiver_union_ids", this.ReceiverUnionIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("at_union_ids", this.AtUnionIds, 999);
            RequestValidator.ValidateRequired("msg_key", this.MsgKey);
            RequestValidator.ValidateRequired("msg_param", this.MsgParam);
            RequestValidator.ValidateRequired("open_conversation_id", this.OpenConversationId);
            RequestValidator.ValidateMaxListSize("receiver_union_ids", this.ReceiverUnionIds, 999);
        }

        #endregion
    }
}
