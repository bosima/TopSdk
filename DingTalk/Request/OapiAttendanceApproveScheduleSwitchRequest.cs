using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.approve.schedule.switch
    /// </summary>
    public class OapiAttendanceApproveScheduleSwitchRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceApproveScheduleSwitchResponse>
    {
        /// <summary>
        /// 申请人换班日期当天的班次id
        /// </summary>
        public Nullable<long> ApplyShiftId { get; set; }

        /// <summary>
        /// 申请换班人id，仅支持排班制考勤组用户
        /// </summary>
        public string ApplyUserid { get; set; }

        /// <summary>
        /// 审批单唯一id
        /// </summary>
        public string ApproveId { get; set; }

        /// <summary>
        /// 申请人还班日期当天的班次id
        /// </summary>
        public Nullable<long> RebackApplyShiftId { get; set; }

        /// <summary>
        /// 还班日期，当天必须有排班或排休，如果申请换班人和被换班人是同一个人，那么必须要有还班日期
        /// </summary>
        public string RebackDate { get; set; }

        /// <summary>
        /// 被换班人还班日期当天的班次id
        /// </summary>
        public Nullable<long> RebackTargetShiftId { get; set; }

        /// <summary>
        /// 申请换班日期，当天必须有排班或排休
        /// </summary>
        public string SwitchDate { get; set; }

        /// <summary>
        /// 被换班人换班日期当天的班次id
        /// </summary>
        public Nullable<long> TargetShiftId { get; set; }

        /// <summary>
        /// 被换班人id，仅支持排班制考勤组用户
        /// </summary>
        public string TargetUserid { get; set; }

        /// <summary>
        /// 发起人的user_id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.approve.schedule.switch";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("apply_shift_id", this.ApplyShiftId);
            parameters.Add("apply_userid", this.ApplyUserid);
            parameters.Add("approve_id", this.ApproveId);
            parameters.Add("reback_apply_shift_id", this.RebackApplyShiftId);
            parameters.Add("reback_date", this.RebackDate);
            parameters.Add("reback_target_shift_id", this.RebackTargetShiftId);
            parameters.Add("switch_date", this.SwitchDate);
            parameters.Add("target_shift_id", this.TargetShiftId);
            parameters.Add("target_userid", this.TargetUserid);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("apply_userid", this.ApplyUserid);
            RequestValidator.ValidateRequired("approve_id", this.ApproveId);
            RequestValidator.ValidateMaxLength("approve_id", this.ApproveId, 100);
            RequestValidator.ValidateRequired("switch_date", this.SwitchDate);
            RequestValidator.ValidateRequired("target_userid", this.TargetUserid);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
