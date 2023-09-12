using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.robot.message.sendgroup
    /// </summary>
    public class OapiRobotMessageSendgroupRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRobotMessageSendgroupResponse>
    {
        /// <summary>
        /// 申请到的消息模板唯一标识符
        /// </summary>
        public string MsgKey { get; set; }

        /// <summary>
        /// 消息模板中，变量本次替换的值
        /// </summary>
        public string MsgParam { get; set; }

        /// <summary>
        /// 群机器人webhook中的token
        /// </summary>
        public string Token { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.robot.message.sendgroup";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("msg_key", this.MsgKey);
            parameters.Add("msg_param", this.MsgParam);
            parameters.Add("token", this.Token);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("msg_key", this.MsgKey);
            RequestValidator.ValidateRequired("msg_param", this.MsgParam);
            RequestValidator.ValidateRequired("token", this.Token);
        }

        #endregion
    }
}
