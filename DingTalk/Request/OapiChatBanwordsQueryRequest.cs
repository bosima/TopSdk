using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.banwords.query
    /// </summary>
    public class OapiChatBanwordsQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatBanwordsQueryResponse>
    {
        /// <summary>
        /// 会话ID
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 被查询的用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.banwords.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatid", this.Chatid);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatid", this.Chatid);
        }

        #endregion
    }
}
