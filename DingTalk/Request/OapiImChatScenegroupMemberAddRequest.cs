using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.scenegroup.member.add
    /// </summary>
    public class OapiImChatScenegroupMemberAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatScenegroupMemberAddResponse>
    {
        /// <summary>
        /// 客户联系人staffIds
        /// </summary>
        public string ContactStaffIds { get; set; }

        /// <summary>
        /// 开放群id
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 成员userid
        /// </summary>
        public string UserIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.scenegroup.member.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("contact_staff_ids", this.ContactStaffIds);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("user_ids", this.UserIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("contact_staff_ids", this.ContactStaffIds, 999);
            RequestValidator.ValidateRequired("open_conversation_id", this.OpenConversationId);
            RequestValidator.ValidateMaxListSize("user_ids", this.UserIds, 999);
        }

        #endregion
    }
}
