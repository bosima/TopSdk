using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sns.conversation.member.list
    /// </summary>
    public class OapiSnsConversationMemberListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSnsConversationMemberListResponse>
    {
        /// <summary>
        /// 分页游标, 由接口返回
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 分页数量, 每页最大100
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sns.conversation.member.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateRequired("open_conversation_id", this.OpenConversationId);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
