using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.group.users.add
    /// </summary>
    public class OapiAttendanceGroupUsersAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupUsersAddResponse>
    {
        /// <summary>
        /// 考勤组id
        /// </summary>
        public string GroupKey { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 用户列表
        /// </summary>
        public string UserIdList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.group.users.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_key", this.GroupKey);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("user_id_list", this.UserIdList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group_key", this.GroupKey);
            RequestValidator.ValidateRequired("user_id_list", this.UserIdList);
            RequestValidator.ValidateMaxListSize("user_id_list", this.UserIdList, 100);
        }

        #endregion
    }
}
