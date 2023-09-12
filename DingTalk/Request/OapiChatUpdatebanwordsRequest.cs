using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.updatebanwords
    /// </summary>
    public class OapiChatUpdatebanwordsRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatUpdatebanwordsResponse>
    {
        /// <summary>
        /// 禁言时间，单位ms
        /// </summary>
        public Nullable<long> BanWordsTime { get; set; }

        /// <summary>
        /// chatid
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 0表示剔除禁言名单，1表示加入禁言名单
        /// </summary>
        public Nullable<long> Type { get; set; }

        /// <summary>
        /// 被禁言人id列表
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.updatebanwords";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ban_words_time", this.BanWordsTime);
            parameters.Add("chatid", this.Chatid);
            parameters.Add("type", this.Type);
            parameters.Add("userid_list", this.UseridList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ban_words_time", this.BanWordsTime);
            RequestValidator.ValidateRequired("chatid", this.Chatid);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateRequired("userid_list", this.UseridList);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 20);
        }

        #endregion
    }
}
