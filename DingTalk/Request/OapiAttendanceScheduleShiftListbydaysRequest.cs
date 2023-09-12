using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.schedule.shift.listbydays
    /// </summary>
    public class OapiAttendanceScheduleShiftListbydaysRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceScheduleShiftListbydaysResponse>
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        public Nullable<long> FromDateTime { get; set; }

        /// <summary>
        /// 操作者userId
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public Nullable<long> ToDateTime { get; set; }

        /// <summary>
        /// 人员userIds
        /// </summary>
        public string Userids { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.schedule.shift.listbydays";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("from_date_time", this.FromDateTime);
            parameters.Add("op_user_id", this.OpUserId);
            parameters.Add("to_date_time", this.ToDateTime);
            parameters.Add("userids", this.Userids);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("from_date_time", this.FromDateTime);
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
            RequestValidator.ValidateRequired("to_date_time", this.ToDateTime);
            RequestValidator.ValidateRequired("userids", this.Userids);
            RequestValidator.ValidateMaxListSize("userids", this.Userids, 20);
        }

        #endregion
    }
}
