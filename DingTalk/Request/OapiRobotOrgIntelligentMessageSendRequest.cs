using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.robot.org.intelligent.message.send
    /// </summary>
    public class OapiRobotOrgIntelligentMessageSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRobotOrgIntelligentMessageSendResponse>
    {
        /// <summary>
        /// at人的userid列表，英文逗号分隔
        /// </summary>
        public string AtUserIds { get; set; }

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
        /// 接收者userid列表，英文逗号分隔，不传表示全员接收
        /// </summary>
        public string ReceiverUserIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.robot.org.intelligent.message.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("at_user_ids", this.AtUserIds);
            parameters.Add("msg_key", this.MsgKey);
            parameters.Add("msg_param", this.MsgParam);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("receiver_user_ids", this.ReceiverUserIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("at_user_ids", this.AtUserIds, 999);
            RequestValidator.ValidateRequired("msg_key", this.MsgKey);
            RequestValidator.ValidateRequired("msg_param", this.MsgParam);
            RequestValidator.ValidateRequired("open_conversation_id", this.OpenConversationId);
            RequestValidator.ValidateMaxListSize("receiver_user_ids", this.ReceiverUserIds, 999);
        }

        #endregion
    }
}
