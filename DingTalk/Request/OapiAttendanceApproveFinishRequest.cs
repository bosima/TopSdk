using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.approve.finish
    /// </summary>
    public class OapiAttendanceApproveFinishRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceApproveFinishResponse>
    {
        /// <summary>
        /// 审批单全局唯一id，最大长度100个字符
        /// </summary>
        public string ApproveId { get; set; }

        /// <summary>
        /// 审批单类型1:加班，2：外出、出差，3：请假
        /// </summary>
        public Nullable<long> BizType { get; set; }

        /// <summary>
        /// 计算方法，0：按自然日计算，1：按工作日计算
        /// </summary>
        public Nullable<long> CalculateModel { get; set; }

        /// <summary>
        /// 钉钉侧审批单全局唯一id，最大长度64个字符
        /// </summary>
        public string DingtalkApproveId { get; set; }

        /// <summary>
        /// 时长单位，支持的day,halfDay,hour，biz_type为1时仅支持hour。时间格式必须与时长单位对应，2019-08-15对应day，2019-08-15  AM对应halfDay，2019-08-15 12:43对应hour
        /// </summary>
        public string DurationUnit { get; set; }

        /// <summary>
        /// 开始时间，支持的时间格式 2019-08-15/2019-08-15 AM/2019-08-15 12:43。开始时间不能早于当前时间前31天
        /// </summary>
        public string FromTime { get; set; }

        /// <summary>
        /// 审批单跳转地址，最大长度100个字符
        /// </summary>
        public string JumpUrl { get; set; }

        /// <summary>
        /// biz_type为1时必传，加班时长单位小时
        /// </summary>
        public string OvertimeDuration { get; set; }

        /// <summary>
        /// biz_type为1时必传，1：加班转调休，2：加班转工资
        /// </summary>
        public Nullable<long> OvertimeToMore { get; set; }

        /// <summary>
        /// 子类型名称，最大长度20个字符
        /// </summary>
        public string SubType { get; set; }

        /// <summary>
        /// 审批单类型名称，最大长度20个字符
        /// </summary>
        public string TagName { get; set; }

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
            return "dingtalk.oapi.attendance.approve.finish";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("approve_id", this.ApproveId);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("calculate_model", this.CalculateModel);
            parameters.Add("dingtalk_approve_id", this.DingtalkApproveId);
            parameters.Add("duration_unit", this.DurationUnit);
            parameters.Add("from_time", this.FromTime);
            parameters.Add("jump_url", this.JumpUrl);
            parameters.Add("overtime_duration", this.OvertimeDuration);
            parameters.Add("overtime_to_more", this.OvertimeToMore);
            parameters.Add("sub_type", this.SubType);
            parameters.Add("tag_name", this.TagName);
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
            RequestValidator.ValidateMaxLength("approve_id", this.ApproveId, 100);
            RequestValidator.ValidateMaxLength("dingtalk_approve_id", this.DingtalkApproveId, 64);
            RequestValidator.ValidateMaxLength("jump_url", this.JumpUrl, 200);
            RequestValidator.ValidateMaxLength("sub_type", this.SubType, 20);
            RequestValidator.ValidateMaxLength("tag_name", this.TagName, 20);
        }

        #endregion
    }
}
