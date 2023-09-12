using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.approve.cancel
    /// </summary>
    public class OapiAttendanceApproveCancelRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceApproveCancelResponse>
    {
        /// <summary>
        /// 审批单全局唯一id，最大长度100个字符
        /// </summary>
        public string ApproveId { get; set; }

        /// <summary>
        /// 钉钉侧审批单全局唯一id，最大长度64个字符
        /// </summary>
        public string DingtalkApproveId { get; set; }

        /// <summary>
        /// 子类型名称，最大长度20个字符
        /// </summary>
        public string SubType { get; set; }

        /// <summary>
        /// 审批单类型名称，最大长度20个字符
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// 员工的user_id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.approve.cancel";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("approve_id", this.ApproveId);
            parameters.Add("dingtalk_approve_id", this.DingtalkApproveId);
            parameters.Add("sub_type", this.SubType);
            parameters.Add("tag_name", this.TagName);
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
            RequestValidator.ValidateMaxLength("sub_type", this.SubType, 20);
            RequestValidator.ValidateMaxLength("tag_name", this.TagName, 20);
        }

        #endregion
    }
}
