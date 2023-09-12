using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingmi.common.robot.ask
    /// </summary>
    public class OapiDingmiCommonRobotAskRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingmiCommonRobotAskResponse>
    {
        /// <summary>
        /// 问题内容
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// 机器人唯一标识
        /// </summary>
        public string RobotAppKey { get; set; }

        /// <summary>
        /// 会话id为了跟踪某一次会话
        /// </summary>
        public string SessionUuid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingmi.common.robot.ask";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("question", this.Question);
            parameters.Add("robot_app_key", this.RobotAppKey);
            parameters.Add("session_uuid", this.SessionUuid);
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
