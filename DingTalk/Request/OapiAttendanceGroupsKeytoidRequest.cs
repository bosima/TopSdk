using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.groups.keytoid
    /// </summary>
    public class OapiAttendanceGroupsKeytoidRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupsKeytoidResponse>
    {
        /// <summary>
        /// groupKey
        /// </summary>
        public string GroupKey { get; set; }

        /// <summary>
        /// 操作人的userId
        /// </summary>
        public string OpUserId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.groups.keytoid";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_key", this.GroupKey);
            parameters.Add("op_user_id", this.OpUserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group_key", this.GroupKey);
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
        }

        #endregion
    }
}
