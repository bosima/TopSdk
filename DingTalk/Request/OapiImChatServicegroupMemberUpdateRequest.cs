using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.servicegroup.member.update
    /// </summary>
    public class OapiImChatServicegroupMemberUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatServicegroupMemberUpdateResponse>
    {
        /// <summary>
        /// 更新类型，REMOVE 移除、SET_ADMIN设为管理员、SET_NORMAL 设为普通成员
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 开放的chatId
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// 成员的ID列表，英文逗号分隔
        /// </summary>
        public string MemberDingtalkIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.servicegroup.member.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("action", this.Action);
            parameters.Add("chat_id", this.ChatId);
            parameters.Add("member_dingtalk_ids", this.MemberDingtalkIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("action", this.Action);
            RequestValidator.ValidateRequired("chat_id", this.ChatId);
            RequestValidator.ValidateRequired("member_dingtalk_ids", this.MemberDingtalkIds);
            RequestValidator.ValidateMaxListSize("member_dingtalk_ids", this.MemberDingtalkIds, 20);
        }

        #endregion
    }
}
