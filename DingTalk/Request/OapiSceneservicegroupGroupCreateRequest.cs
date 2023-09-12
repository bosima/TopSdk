using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sceneservicegroup.group.create
    /// </summary>
    public class OapiSceneservicegroupGroupCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSceneservicegroupGroupCreateResponse>
    {
        /// <summary>
        /// 业务关联
        /// </summary>
        public string Bizid { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 群标签
        /// </summary>
        public string GroupTagNames { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        public string GroupTagids { get; set; }

        /// <summary>
        /// 成员员工列表
        /// </summary>
        public string MemberStaffids { get; set; }

        /// <summary>
        /// 服务群群组ID
        /// </summary>
        public string OpenGroupsetid { get; set; }

        /// <summary>
        /// 服务群团队ID
        /// </summary>
        public string OpenTeamid { get; set; }

        /// <summary>
        /// 群主员工id
        /// </summary>
        public string OwnerStaffId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sceneservicegroup.group.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bizid", this.Bizid);
            parameters.Add("group_name", this.GroupName);
            parameters.Add("group_tag_names", this.GroupTagNames);
            parameters.Add("group_tagids", this.GroupTagids);
            parameters.Add("member_staffids", this.MemberStaffids);
            parameters.Add("open_groupsetid", this.OpenGroupsetid);
            parameters.Add("open_teamid", this.OpenTeamid);
            parameters.Add("owner_staffId", this.OwnerStaffId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group_name", this.GroupName);
            RequestValidator.ValidateMaxListSize("group_tag_names", this.GroupTagNames, 999);
            RequestValidator.ValidateMaxListSize("group_tagids", this.GroupTagids, 999);
            RequestValidator.ValidateMaxListSize("member_staffids", this.MemberStaffids, 999);
            RequestValidator.ValidateRequired("open_groupsetid", this.OpenGroupsetid);
            RequestValidator.ValidateRequired("open_teamid", this.OpenTeamid);
            RequestValidator.ValidateRequired("owner_staffId", this.OwnerStaffId);
        }

        #endregion
    }
}
