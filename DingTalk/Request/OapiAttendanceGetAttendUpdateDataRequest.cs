using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.getAttendUpdateData
    /// </summary>
    public class OapiAttendanceGetAttendUpdateDataRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGetAttendUpdateDataResponse>
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 工作日
        /// </summary>
        public Nullable<DateTime> WorkDate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.getAttendUpdateData";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("userid", this.Userid);
            parameters.Add("work_date", this.WorkDate);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("userid", this.Userid);
            RequestValidator.ValidateRequired("work_date", this.WorkDate);
        }

        #endregion
    }
}
