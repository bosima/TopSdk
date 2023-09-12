using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.corp.conversation.member.list
    /// </summary>
    public class OapiCorpConversationMemberListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCorpConversationMemberListResponse>
    {
        /// <summary>
        /// 会话ID
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// 偏移位置，从0开始，后续传offset+size的值。member_list返回为空表示结束了。
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 请求数量
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.corp.conversation.member.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chat_id", this.ChatId);
            parameters.Add("offset", this.Offset);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chat_id", this.ChatId);
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 200);
        }

        #endregion
    }
}
