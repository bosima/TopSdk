using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ccoservice.servicegroup.updateservicetime
    /// </summary>
    public class OapiCcoserviceServicegroupUpdateservicetimeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCcoserviceServicegroupUpdateservicetimeResponse>
    {
        /// <summary>
        /// 服务结束时间
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 群加密id
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 日期类型,0-工作日;1-每日;99-端上不显示
        /// </summary>
        public Nullable<long> TimeType { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ccoservice.servicegroup.updateservicetime";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("time_type", this.TimeType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("open_conversation_id", this.OpenConversationId);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
        }

        #endregion
    }
}
