using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingmi.robot.push
    /// </summary>
    public class OapiDingmiRobotPushRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingmiRobotPushResponse>
    {
        /// <summary>
        /// 会话ID
        /// </summary>
        public string ConversationId { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public string MsgKey { get; set; }

        /// <summary>
        /// 参考文档
        /// </summary>
        public string MsgParam { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingmi.robot.push";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("conversation_id", this.ConversationId);
            parameters.Add("msg_key", this.MsgKey);
            parameters.Add("msg_param", this.MsgParam);
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
