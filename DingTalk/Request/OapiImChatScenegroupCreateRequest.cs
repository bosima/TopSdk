using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.scenegroup.create
    /// </summary>
    public class OapiImChatScenegroupCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatScenegroupCreateResponse>
    {
        /// <summary>
        /// 禁止群成员私聊 若开启，普通群成员之间不能够加好友、单聊，且部分功能使用受限（管理员与非管理员之间不受影响）0-不开启，1-开启
        /// </summary>
        public Nullable<long> AddFriendForbidden { get; set; }

        /// <summary>
        /// 群日历 若开启，群内容非好友/同事的成员可相互发起钉钉日程 0-不开启，1-开启
        /// </summary>
        public Nullable<long> AllMembersCanCreateCalendar { get; set; }

        /// <summary>
        /// 群会议 若开启，群内任意成员可发起视频和语音会议 0-不开启，1-开启
        /// </summary>
        public Nullable<long> AllMembersCanCreateMcsConf { get; set; }

        /// <summary>
        /// 群禁言，0-默认，不禁言，1-全员禁言
        /// </summary>
        public Nullable<long> ChatBannedType { get; set; }

        /// <summary>
        /// 禁止发送群邮件 若开启，群内成员不可再对本群发送群邮件 0-不开启，1-开启
        /// </summary>
        public Nullable<long> GroupEmailDisabled { get; set; }

        /// <summary>
        /// 群直播 若开启，群内任意成员可发起群直播 0-不开启，1-开启
        /// </summary>
        public Nullable<long> GroupLiveSwitch { get; set; }

        /// <summary>
        /// 群头像mediaId
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 管理类型，0-默认，所有人可管理，1-仅群主可管理
        /// </summary>
        public Nullable<long> ManagementType { get; set; }

        /// <summary>
        /// 禁止非管理员向管理员发起单聊 若开启，非管理员不能向管理员发起单聊 0-不开启，1-开启
        /// </summary>
        public Nullable<long> MembersToAdminChat { get; set; }

        /// <summary>
        /// @all 权限，0-默认，所有人，1-仅群主可@all
        /// </summary>
        public Nullable<long> MentionAllAuthority { get; set; }

        /// <summary>
        /// 仅群主和管理员可在群内发DING  0-不开启，1-开启
        /// </summary>
        public Nullable<long> OnlyAdminCanDing { get; set; }

        /// <summary>
        /// 仅群主和管理员可置顶群消息 0-不开启，1-开启
        /// </summary>
        public Nullable<long> OnlyAdminCanSetMsgTop { get; set; }

        /// <summary>
        /// 群主userid
        /// </summary>
        public string OwnerUserId { get; set; }

        /// <summary>
        /// 群可搜索，0-默认，不可搜索，1-可搜索
        /// </summary>
        public Nullable<long> Searchable { get; set; }

        /// <summary>
        /// 新成员是否可查看聊天历史消息，0-默认，否，1-是
        /// </summary>
        public Nullable<long> ShowHistoryType { get; set; }

        /// <summary>
        /// 群管理员useridlist
        /// </summary>
        public string SubadminIds { get; set; }

        /// <summary>
        /// 群模板id
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 群成员useridlist
        /// </summary>
        public string UserIds { get; set; }

        /// <summary>
        /// 建群去重的业务id
        /// </summary>
        public string Uuid { get; set; }

        /// <summary>
        /// 入群验证，0：不入群验证（默认） 1：入群验证
        /// </summary>
        public Nullable<long> ValidationType { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.scenegroup.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("add_friend_forbidden", this.AddFriendForbidden);
            parameters.Add("all_members_can_create_calendar", this.AllMembersCanCreateCalendar);
            parameters.Add("all_members_can_create_mcs_conf", this.AllMembersCanCreateMcsConf);
            parameters.Add("chat_banned_type", this.ChatBannedType);
            parameters.Add("group_email_disabled", this.GroupEmailDisabled);
            parameters.Add("group_live_switch", this.GroupLiveSwitch);
            parameters.Add("icon", this.Icon);
            parameters.Add("management_type", this.ManagementType);
            parameters.Add("members_to_admin_chat", this.MembersToAdminChat);
            parameters.Add("mention_all_authority", this.MentionAllAuthority);
            parameters.Add("only_admin_can_ding", this.OnlyAdminCanDing);
            parameters.Add("only_admin_can_set_msg_top", this.OnlyAdminCanSetMsgTop);
            parameters.Add("owner_user_id", this.OwnerUserId);
            parameters.Add("searchable", this.Searchable);
            parameters.Add("show_history_type", this.ShowHistoryType);
            parameters.Add("subadmin_ids", this.SubadminIds);
            parameters.Add("template_id", this.TemplateId);
            parameters.Add("title", this.Title);
            parameters.Add("user_ids", this.UserIds);
            parameters.Add("uuid", this.Uuid);
            parameters.Add("validation_type", this.ValidationType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("owner_user_id", this.OwnerUserId);
            RequestValidator.ValidateMaxListSize("subadmin_ids", this.SubadminIds, 999);
            RequestValidator.ValidateRequired("template_id", this.TemplateId);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxListSize("user_ids", this.UserIds, 999);
        }

        #endregion
    }
}
