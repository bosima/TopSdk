using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.create
    /// </summary>
    public class OapiChatCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatCreateResponse>
    {
        /// <summary>
        /// 群禁言，0-默认，不禁言，1-全员禁言
        /// </summary>
        public Nullable<long> ChatBannedType { get; set; }

        /// <summary>
        /// 群类型，2：企业群，0：普通群
        /// </summary>
        public Nullable<long> ConversationTag { get; set; }

        /// <summary>
        /// 外部联系人成员列表
        /// </summary>
        public List<string> Extidlist { get; set; }

        /// <summary>
        /// 群头像资源id
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 管理类型，0-默认，所有人可管理，1-仅群主可管理
        /// </summary>
        public Nullable<long> ManagementType { get; set; }

        /// <summary>
        /// @all 权限，0-默认，所有人，1-仅群主可@all
        /// </summary>
        public Nullable<long> MentionAllAuthority { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 群主的userId
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// 群主类型，emp：企业员工，ext：外部联系人
        /// </summary>
        public string OwnerType { get; set; }

        /// <summary>
        /// 群可搜索，0-默认，不可搜索，1-可搜索
        /// </summary>
        public Nullable<long> Searchable { get; set; }

        /// <summary>
        /// 新成员可查看100条聊天历史消息的类型，1：可查看，默认或0：不可查看
        /// </summary>
        public Nullable<long> ShowHistoryType { get; set; }

        /// <summary>
        /// 群成员userId列表
        /// </summary>
        public List<string> Useridlist { get; set; }

        /// <summary>
        /// 入群验证，0：不入群验证（默认） 1：入群验证
        /// </summary>
        public Nullable<long> ValidationType { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatBannedType", this.ChatBannedType);
            parameters.Add("conversationTag", this.ConversationTag);
            parameters.Add("extidlist", TopUtils.ObjectToJson(this.Extidlist));
            parameters.Add("icon", this.Icon);
            parameters.Add("managementType", this.ManagementType);
            parameters.Add("mentionAllAuthority", this.MentionAllAuthority);
            parameters.Add("name", this.Name);
            parameters.Add("owner", this.Owner);
            parameters.Add("ownerType", this.OwnerType);
            parameters.Add("searchable", this.Searchable);
            parameters.Add("showHistoryType", this.ShowHistoryType);
            parameters.Add("useridlist", TopUtils.ObjectToJson(this.Useridlist));
            parameters.Add("validationType", this.ValidationType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("extidlist", this.Extidlist, 20);
            RequestValidator.ValidateMaxListSize("useridlist", this.Useridlist, 20);
        }

        #endregion
    }
}
