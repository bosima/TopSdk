using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.conversation.corpconversion.listmember
    /// </summary>
    public class CorpConversationCorpconversionListmemberRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpConversationCorpconversionListmemberResponse>
    {
        /// <summary>
        /// 本次请求获取群成员的大小，最大为100
        /// </summary>
        public Nullable<long> Count { get; set; }

        /// <summary>
        /// 群成员列表偏移量
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 群组id
        /// </summary>
        public string OpenConversationId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.conversation.corpconversion.listmember";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("count", this.Count);
            parameters.Add("offset", this.Offset);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("count", this.Count);
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateRequired("open_conversation_id", this.OpenConversationId);
        }

        #endregion
    }
}
