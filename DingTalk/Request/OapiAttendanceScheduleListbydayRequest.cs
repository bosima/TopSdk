using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.schedule.listbyday
    /// </summary>
    public class OapiAttendanceScheduleListbydayRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceScheduleListbydayResponse>
    {
        /// <summary>
        /// 查询那天的数据
        /// </summary>
        public Nullable<long> DateTime { get; set; }

        /// <summary>
        /// 操作者userId
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 用户userId
        /// </summary>
        public string UserId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.schedule.listbyday";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("date_time", this.DateTime);
            parameters.Add("op_user_id", this.OpUserId);
            parameters.Add("user_id", this.UserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("date_time", this.DateTime);
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
            RequestValidator.ValidateRequired("user_id", this.UserId);
        }

        #endregion
    }
}
