using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.robot.message.orggrouptask.query
    /// </summary>
    public class OapiRobotMessageOrggrouptaskQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRobotMessageOrggrouptaskQueryResponse>
    {
        /// <summary>
        /// 申请到的企业机器人唯一标识符
        /// </summary>
        public string ChatbotId { get; set; }

        /// <summary>
        /// 分页游标
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// 开放的群ID
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 每页请求数量
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 用于查询发送进度的唯一标识
        /// </summary>
        public string ProcessQueryKey { get; set; }

        /// <summary>
        /// 机器人webhook中的access_token参数，与chatbot_id+open_conversation_id 只需要填1种
        /// </summary>
        public string Token { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.robot.message.orggrouptask.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatbot_id", this.ChatbotId);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("page_size", this.PageSize);
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
        }

        #endregion
    }
}
