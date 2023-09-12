using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.robot.message.statistics.list
    /// </summary>
    public class OapiRobotMessageStatisticsListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRobotMessageStatisticsListResponse>
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        public Nullable<long> Page { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 机器人消息推送Id列表
        /// </summary>
        public string PushIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.robot.message.statistics.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("page", this.Page);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("push_ids", this.PushIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("push_ids", this.PushIds);
            RequestValidator.ValidateMaxListSize("push_ids", this.PushIds, 20);
        }

        #endregion
    }
}
