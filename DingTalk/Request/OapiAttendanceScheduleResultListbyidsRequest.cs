using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.schedule.result.listbyids
    /// </summary>
    public class OapiAttendanceScheduleResultListbyidsRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceScheduleResultListbyidsResponse>
    {
        /// <summary>
        /// 操作者userId
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 排班ids
        /// </summary>
        public string ScheduleIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.schedule.result.listbyids";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("op_user_id", this.OpUserId);
            parameters.Add("schedule_ids", this.ScheduleIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
            RequestValidator.ValidateRequired("schedule_ids", this.ScheduleIds);
            RequestValidator.ValidateMaxListSize("schedule_ids", this.ScheduleIds, 100);
        }

        #endregion
    }
}
