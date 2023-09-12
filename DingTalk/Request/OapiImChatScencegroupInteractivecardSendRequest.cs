using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.scencegroup.interactivecard.send
    /// </summary>
    public class OapiImChatScencegroupInteractivecardSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatScencegroupInteractivecardSendResponse>
    {
        /// <summary>
        /// 卡片模板内容替换参数-多媒体类型
        /// </summary>
        public string CardMediaidParamMap { get; set; }

        /// <summary>
        /// 卡片模板内容替换参数-普通文本类型
        /// </summary>
        public string CardParamMap { get; set; }

        /// <summary>
        /// 卡片模板ID
        /// </summary>
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 唯一标示卡片的外部编码
        /// </summary>
        public string OutTrackId { get; set; }

        /// <summary>
        /// 接收卡片的人的userId
        /// </summary>
        public string ReceiverUseridList { get; set; }

        /// <summary>
        /// 用于发送卡片的机器人编码，与场景群模板中的机器人编码保持一致
        /// </summary>
        public string RobotCode { get; set; }

        /// <summary>
        /// 接收卡片的群的openConversationId
        /// </summary>
        public string TargetOpenConversationId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.scencegroup.interactivecard.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("card_mediaid_param_map", this.CardMediaidParamMap);
            parameters.Add("card_param_map", this.CardParamMap);
            parameters.Add("card_template_id", this.CardTemplateId);
            parameters.Add("out_track_id", this.OutTrackId);
            parameters.Add("receiver_userid_list", this.ReceiverUseridList);
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
            RequestValidator.ValidateRequired("card_template_id", this.CardTemplateId);
            RequestValidator.ValidateRequired("out_track_id", this.OutTrackId);
            RequestValidator.ValidateMaxListSize("receiver_userid_list", this.ReceiverUseridList, 999);
            RequestValidator.ValidateRequired("robot_code", this.RobotCode);
            RequestValidator.ValidateRequired("target_open_conversation_id", this.TargetOpenConversationId);
        }

        #endregion
    }
}
