using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.updategroupnick
    /// </summary>
    public class OapiChatUpdategroupnickRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatUpdategroupnickResponse>
    {
        /// <summary>
        /// chatid
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 群昵称
        /// </summary>
        public string GroupNick { get; set; }

        /// <summary>
        /// 用户userid
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.updategroupnick";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatid", this.Chatid);
            parameters.Add("group_nick", this.GroupNick);
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
            RequestValidator.ValidateRequired("group_nick", this.GroupNick);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
