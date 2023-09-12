using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.approve.check
    /// </summary>
    public class OapiAttendanceApproveCheckRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceApproveCheckResponse>
    {
        /// <summary>
        /// 审批单id，全局唯一
        /// </summary>
        public string ApproveId { get; set; }

        /// <summary>
        /// 审批单跳转地址
        /// </summary>
        public string JumpUrl { get; set; }

        /// <summary>
        /// 排班时间
        /// </summary>
        public string PunchCheckTime { get; set; }

        /// <summary>
        /// 要补的排班id
        /// </summary>
        public Nullable<long> PunchId { get; set; }

        /// <summary>
        /// 审批单名称
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// 用户打卡时间
        /// </summary>
        public string UserCheckTime { get; set; }

        /// <summary>
        /// 员工的user_id
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 要补哪一天的卡，注意这个日期不是实际要补的日期，而是班次的日期。例如用户要补卡的时间是2019-08-16 00:20，排班时间是2019-08-15 23：50，那么这里要传的日期是2019-08-15
        /// </summary>
        public string WorkDate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.approve.check";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("approve_id", this.ApproveId);
            parameters.Add("jump_url", this.JumpUrl);
            parameters.Add("punch_check_time", this.PunchCheckTime);
            parameters.Add("punch_id", this.PunchId);
            parameters.Add("tag_name", this.TagName);
            parameters.Add("user_check_time", this.UserCheckTime);
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
        }

        #endregion
    }
}
