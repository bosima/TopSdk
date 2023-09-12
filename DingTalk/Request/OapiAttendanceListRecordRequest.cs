using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.listRecord
    /// </summary>
    public class OapiAttendanceListRecordRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceListRecordResponse>
    {
        /// <summary>
        /// 查询考勤打卡记录的结束工作日。注意，起始与结束工作日最多相隔7天
        /// </summary>
        public string CheckDateFrom { get; set; }

        /// <summary>
        /// 查询考勤打卡记录的结束工作日。注意，起始与结束工作日最多相隔7天
        /// </summary>
        public string CheckDateTo { get; set; }

        /// <summary>
        /// 是否国际化
        /// </summary>
        public Nullable<bool> IsI18n { get; set; }

        /// <summary>
        /// 企业内的员工id列表，最多不能超过50个
        /// </summary>
        public List<string> UserIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.listRecord";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("checkDateFrom", this.CheckDateFrom);
            parameters.Add("checkDateTo", this.CheckDateTo);
            parameters.Add("isI18n", this.IsI18n);
            parameters.Add("userIds", TopUtils.ObjectToJson(this.UserIds));
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("checkDateFrom", this.CheckDateFrom);
            RequestValidator.ValidateRequired("checkDateTo", this.CheckDateTo);
            RequestValidator.ValidateRequired("userIds", this.UserIds);
        }

        #endregion
    }
}
