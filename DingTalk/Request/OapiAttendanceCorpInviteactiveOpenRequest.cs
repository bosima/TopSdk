using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.corp.inviteactive.open
    /// </summary>
    public class OapiAttendanceCorpInviteactiveOpenRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceCorpInviteactiveOpenResponse>
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string AdminName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string AdminPhone { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.corp.inviteactive.open";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("admin_name", this.AdminName);
            parameters.Add("admin_phone", this.AdminPhone);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("admin_name", this.AdminName);
            RequestValidator.ValidateRequired("admin_phone", this.AdminPhone);
        }

        #endregion
    }
}
