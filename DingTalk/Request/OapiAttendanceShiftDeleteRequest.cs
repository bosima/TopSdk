using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.shift.delete
    /// </summary>
    public class OapiAttendanceShiftDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceShiftDeleteResponse>
    {
        /// <summary>
        /// 操作人
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 班次id
        /// </summary>
        public Nullable<long> ShiftId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.shift.delete";
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
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
            RequestValidator.ValidateRequired("shift_id", this.ShiftId);
        }

        #endregion
    }
}
