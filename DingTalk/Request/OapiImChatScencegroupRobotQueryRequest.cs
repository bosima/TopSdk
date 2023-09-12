using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.scencegroup.robot.query
    /// </summary>
    public class OapiImChatScencegroupRobotQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatScencegroupRobotQueryResponse>
    {
        /// <summary>
        /// 群标识
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 群模板关联的群机器人robotCode
        /// </summary>
        public string RobotCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.scencegroup.robot.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("robot_code", this.RobotCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("open_conversation_id", this.OpenConversationId);
            RequestValidator.ValidateRequired("robot_code", this.RobotCode);
        }

        #endregion
    }
}
