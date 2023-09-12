using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.groups.idtokey
    /// </summary>
    public class OapiAttendanceGroupsIdtokeyRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupsIdtokeyResponse>
    {
        /// <summary>
        /// 考勤组的id
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        /// <summary>
        /// 操作用户的userId
        /// </summary>
        public string OpUserId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.groups.idtokey";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_id", this.GroupId);
            parameters.Add("op_user_id", this.OpUserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group_id", this.GroupId);
        }

        #endregion
    }
}
