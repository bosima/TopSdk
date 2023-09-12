using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.listschedule
    /// </summary>
    public class OapiAttendanceListscheduleRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceListscheduleResponse>
    {
        /// <summary>
        /// 偏移位置
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 分页大小，最大200
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 排班时间，只取年月日部分
        /// </summary>
        public Nullable<DateTime> WorkDate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.listschedule";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("offset", this.Offset);
            parameters.Add("size", this.Size);
            parameters.Add("workDate", this.WorkDate);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("workDate", this.WorkDate);
        }

        #endregion
    }
}
