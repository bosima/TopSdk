using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.getleavetimebynames
    /// </summary>
    public class OapiAttendanceGetleavetimebynamesRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGetleavetimebynamesResponse>
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        public Nullable<DateTime> FromDate { get; set; }

        /// <summary>
        /// 假期名称
        /// </summary>
        public string LeaveNames { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public Nullable<DateTime> ToDate { get; set; }

        /// <summary>
        /// 用户的userId
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.getleavetimebynames";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("from_date", this.FromDate);
            parameters.Add("leave_names", this.LeaveNames);
            parameters.Add("to_date", this.ToDate);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("leave_names", this.LeaveNames, 20);
        }

        #endregion
    }
}
