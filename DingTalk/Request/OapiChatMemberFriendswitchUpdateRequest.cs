using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.member.friendswitch.update
    /// </summary>
    public class OapiChatMemberFriendswitchUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatMemberFriendswitchUpdateResponse>
    {
        /// <summary>
        /// 会话Id
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// true开启禁止开关，false关闭禁止开关
        /// </summary>
        public Nullable<bool> IsProhibit { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.member.friendswitch.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatid", this.Chatid);
            parameters.Add("is_prohibit", this.IsProhibit);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatid", this.Chatid);
            RequestValidator.ValidateRequired("is_prohibit", this.IsProhibit);
        }

        #endregion
    }
}
