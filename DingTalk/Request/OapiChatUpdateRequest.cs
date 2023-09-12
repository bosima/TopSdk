using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.update
    /// </summary>
    public class OapiChatUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatUpdateResponse>
    {
        /// <summary>
        /// 添加外部联系人成员列表
        /// </summary>
        public List<string> AddExtidlist { get; set; }

        /// <summary>
        /// 添加成员列表
        /// </summary>
        public List<string> AddUseridlist { get; set; }

        /// <summary>
        /// 群禁言，0-默认，不禁言，1-全员禁言
        /// </summary>
        public Nullable<long> ChatBannedType { get; set; }

        /// <summary>
        /// 群会话id
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 删除外部联系人成员列表
        /// </summary>
        public List<string> DelExtidlist { get; set; }

        /// <summary>
        /// 删除成员列表
        /// </summary>
        public List<string> DelUseridlist { get; set; }

        /// <summary>
        /// 群头像mediaId
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 是否禁言
        /// </summary>
        public Nullable<bool> IsBan { get; set; }

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
        /// 新成员可查看聊天历史 0否 1是
        /// </summary>
        public Nullable<long> ShowHistoryType { get; set; }

        /// <summary>
        /// 入群验证，0：不入群验证（默认） 1：入群验证
        /// </summary>
        public Nullable<long> ValidationType { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("add_extidlist", TopUtils.ObjectToJson(this.AddExtidlist));
            parameters.Add("add_useridlist", TopUtils.ObjectToJson(this.AddUseridlist));
            parameters.Add("chatBannedType", this.ChatBannedType);
            parameters.Add("chatid", this.Chatid);
            parameters.Add("del_extidlist", TopUtils.ObjectToJson(this.DelExtidlist));
            parameters.Add("del_useridlist", TopUtils.ObjectToJson(this.DelUseridlist));
            parameters.Add("icon", this.Icon);
            parameters.Add("isBan", this.IsBan);
            parameters.Add("managementType", this.ManagementType);
            parameters.Add("mentionAllAuthority", this.MentionAllAuthority);
            parameters.Add("name", this.Name);
            parameters.Add("owner", this.Owner);
            parameters.Add("ownerType", this.OwnerType);
            parameters.Add("searchable", this.Searchable);
            parameters.Add("showHistoryType", this.ShowHistoryType);
            parameters.Add("validationType", this.ValidationType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("add_extidlist", this.AddExtidlist, 20);
            RequestValidator.ValidateMaxListSize("add_useridlist", this.AddUseridlist, 20);
            RequestValidator.ValidateMaxListSize("del_extidlist", this.DelExtidlist, 20);
            RequestValidator.ValidateMaxListSize("del_useridlist", this.DelUseridlist, 20);
        }

        #endregion
    }
}
