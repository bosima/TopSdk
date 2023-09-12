using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.shift.history.query
    /// </summary>
    public class OapiAttendanceShiftHistoryQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceShiftHistoryQueryResponse>
    {
        /// <summary>
        /// 操作者userId
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 班次id
        /// </summary>
        public Nullable<long> ShiftId { get; set; }

        /// <summary>
        /// 班次版本
        /// </summary>
        public Nullable<long> Version { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.shift.history.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("op_user_id", this.OpUserId);
            parameters.Add("shift_id", this.ShiftId);
            parameters.Add("version", this.Version);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
            RequestValidator.ValidateRequired("shift_id", this.ShiftId);
            RequestValidator.ValidateRequired("version", this.Version);
        }

        #endregion
    }
}
