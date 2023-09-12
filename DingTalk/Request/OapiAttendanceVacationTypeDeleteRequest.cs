using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.vacation.type.delete
    /// </summary>
    public class OapiAttendanceVacationTypeDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceVacationTypeDeleteResponse>
    {
        /// <summary>
        /// 假期类型唯一标识
        /// </summary>
        public string LeaveCode { get; set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        public string OpUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.vacation.type.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("leave_code", this.LeaveCode);
            parameters.Add("op_userid", this.OpUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("leave_code", this.LeaveCode);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
        }

        #endregion
    }
}
