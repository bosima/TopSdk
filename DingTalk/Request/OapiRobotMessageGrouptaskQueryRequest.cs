using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.robot.message.grouptask.query
    /// </summary>
    public class OapiRobotMessageGrouptaskQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRobotMessageGrouptaskQueryResponse>
    {
        /// <summary>
        /// 用于查询发送进度的唯一标识
        /// </summary>
        public string ProcessQueryKey { get; set; }

        /// <summary>
        /// 群机器人webhook中的token
        /// </summary>
        public string Token { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.robot.message.grouptask.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("process_query_key", this.ProcessQueryKey);
            parameters.Add("token", this.Token);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("process_query_key", this.ProcessQueryKey);
            RequestValidator.ValidateRequired("token", this.Token);
        }

        #endregion
    }
}
