using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.group.member.listbyids
    /// </summary>
    public class OapiAttendanceGroupMemberListbyidsRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupMemberListbyidsResponse>
    {
        /// <summary>
        /// 考勤组id
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        /// <summary>
        /// 成员id，可以是userId或者deptId
        /// </summary>
        public string MemberIds { get; set; }

        /// <summary>
        /// 0 表示员工，1表示部门
        /// </summary>
        public Nullable<long> MemberType { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        public string OpUserId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.group.member.listbyids";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_id", this.GroupId);
            parameters.Add("member_ids", this.MemberIds);
            parameters.Add("member_type", this.MemberType);
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
            RequestValidator.ValidateRequired("member_ids", this.MemberIds);
            RequestValidator.ValidateMaxListSize("member_ids", this.MemberIds, 20);
            RequestValidator.ValidateRequired("member_type", this.MemberType);
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
        }

        #endregion
    }
}
