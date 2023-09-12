using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.scencegroup.message.send
    /// </summary>
    public class OapiImChatScencegroupMessageSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatScencegroupMessageSendResponse>
    {
        /// <summary>
        /// @人的手机号列表
        /// </summary>
        public string AtMobiles { get; set; }

        /// <summary>
        /// 是否@所有人
        /// </summary>
        public Nullable<bool> IsAtAll { get; set; }

        /// <summary>
        /// 消息模板内容替换参数-多媒体类型
        /// </summary>
        public string MsgMediaIdParamMap { get; set; }

        /// <summary>
        /// 消息模板内容替换参数-普通文本类型
        /// </summary>
        public string MsgParamMap { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        public string MsgTemplateId { get; set; }

        /// <summary>
        /// 消息接收人手机号列表（不设置任何接收人则全部可见）
        /// </summary>
        public string ReceiverMobiles { get; set; }

        /// <summary>
        /// 消息接收人 unionId 列表（不设置任何接收人则全部可见）
        /// </summary>
        public string ReceiverUnionIds { get; set; }

        /// <summary>
        /// 消息接收人 userId 列表 （不设置任何接收人则全部可见）
        /// </summary>
        public string ReceiverUserIds { get; set; }

        /// <summary>
        /// 用于发送卡片的机器人编码，与场景群模板中的机器人编码保持一致
        /// </summary>
        public string RobotCode { get; set; }

        /// <summary>
        /// 接收消息的群的openConversationId
        /// </summary>
        public string TargetOpenConversationId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.scencegroup.message.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("at_mobiles", this.AtMobiles);
            parameters.Add("is_at_all", this.IsAtAll);
            parameters.Add("msg_media_id_param_map", this.MsgMediaIdParamMap);
            parameters.Add("msg_param_map", this.MsgParamMap);
            parameters.Add("msg_template_id", this.MsgTemplateId);
            parameters.Add("receiver_mobiles", this.ReceiverMobiles);
            parameters.Add("receiver_union_ids", this.ReceiverUnionIds);
            parameters.Add("receiver_user_ids", this.ReceiverUserIds);
            parameters.Add("robot_code", this.RobotCode);
            parameters.Add("target_open_conversation_id", this.TargetOpenConversationId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("at_mobiles", this.AtMobiles, 999);
            RequestValidator.ValidateRequired("msg_template_id", this.MsgTemplateId);
            RequestValidator.ValidateMaxListSize("receiver_mobiles", this.ReceiverMobiles, 999);
            RequestValidator.ValidateMaxListSize("receiver_union_ids", this.ReceiverUnionIds, 999);
            RequestValidator.ValidateMaxListSize("receiver_user_ids", this.ReceiverUserIds, 999);
            RequestValidator.ValidateRequired("robot_code", this.RobotCode);
            RequestValidator.ValidateRequired("target_open_conversation_id", this.TargetOpenConversationId);
        }

        #endregion
    }
}
