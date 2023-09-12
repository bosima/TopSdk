using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.corp.inviteactive.add
    /// </summary>
    public class OapiAttendanceCorpInviteactiveAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceCorpInviteactiveAddResponse>
    {
        /// <summary>
        /// 管理员的手机号
        /// </summary>
        public string AdminMobile { get; set; }

        /// <summary>
        /// 被邀请员工的手机号
        /// </summary>
        public string InvitedMobile { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.corp.inviteactive.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("admin_mobile", this.AdminMobile);
            parameters.Add("invited_mobile", this.InvitedMobile);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("admin_mobile", this.AdminMobile);
            RequestValidator.ValidateRequired("invited_mobile", this.InvitedMobile);
        }

        #endregion
    }
}
