using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.approve.duration.calculate
    /// </summary>
    public class OapiAttendanceApproveDurationCalculateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceApproveDurationCalculateResponse>
    {
        /// <summary>
        /// 审批单类型1：加班，2：出差，3：请假
        /// </summary>
        public Nullable<long> BizType { get; set; }

        /// <summary>
        /// 计算方法，0：按自然日计算，1：按工作日计算
        /// </summary>
        public Nullable<long> CalculateModel { get; set; }

        /// <summary>
        /// 时长单位，支持的day,halfDay,hour，biz_type为1时仅支持hour。时间格式必须与时长单位对应，2019-08-15对应day，2019-08-15  AM对应halfDay，2019-08-15 12:43对应hour
        /// </summary>
        public string DurationUnit { get; set; }

        /// <summary>
        /// 开始时间，支持的时间格式 2019-08-15/2019-08-15 AM/2019-08-15 12:43。开始时间不能早于当前时间前31天
        /// </summary>
        public string FromTime { get; set; }

        /// <summary>
        /// 结束时间，支持的时间格式 2019-08-15/2019-08-15 AM/2019-08-15 12:43。结束时间减去开始时间的天数不能超过31天。biz_type为1时结束时间减去开始时间不能超过1天
        /// </summary>
        public string ToTime { get; set; }

        /// <summary>
        /// 员工的user_id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.approve.duration.calculate";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
            parameters.Add("calculate_model", this.CalculateModel);
            parameters.Add("duration_unit", this.DurationUnit);
            parameters.Add("from_time", this.FromTime);
            parameters.Add("to_time", this.ToTime);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_type", this.BizType);
            RequestValidator.ValidateRequired("calculate_model", this.CalculateModel);
            RequestValidator.ValidateRequired("duration_unit", this.DurationUnit);
            RequestValidator.ValidateRequired("from_time", this.FromTime);
            RequestValidator.ValidateRequired("to_time", this.ToTime);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
