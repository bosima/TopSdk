using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.shift.query
    /// </summary>
    public class OapiAttendanceShiftQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceShiftQueryResponse>
    {
        /// <summary>
        /// 操作者userId
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 班次id
        /// </summary>
        public Nullable<long> ShiftId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.shift.query";
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
