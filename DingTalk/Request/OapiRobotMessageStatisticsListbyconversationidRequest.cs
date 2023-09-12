using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.robot.message.statistics.listbyconversationid
    /// </summary>
    public class OapiRobotMessageStatisticsListbyconversationidRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRobotMessageStatisticsListbyconversationidResponse>
    {
        /// <summary>
        /// 群Id列表
        /// </summary>
        public string ConversationIds { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public Nullable<long> Page { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 机器人消息推送Id
        /// </summary>
        public string PushId { get; set; }

        /// <summary>
        /// 已读状态
        /// </summary>
        public Nullable<bool> ReadStatus { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.robot.message.statistics.listbyconversationid";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("conversation_ids", this.ConversationIds);
            parameters.Add("page", this.Page);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("push_id", this.PushId);
            parameters.Add("read_status", this.ReadStatus);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("conversation_ids", this.ConversationIds);
            RequestValidator.ValidateMaxListSize("conversation_ids", this.ConversationIds, 20);
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("push_id", this.PushId);
        }

        #endregion
    }
}
