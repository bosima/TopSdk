using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.servicegroup.member.query
    /// </summary>
    public class OapiImChatServicegroupMemberQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatServicegroupMemberQueryResponse>
    {
        /// <summary>
        /// 开放的chatId
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// 0- 不包含群主，1-包含群主
        /// </summary>
        public Nullable<long> IncludeOwner { get; set; }

        /// <summary>
        /// 页码，从1开始
        /// </summary>
        public Nullable<long> PageNum { get; set; }

        /// <summary>
        /// 每页大小，最大100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.servicegroup.member.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chat_id", this.ChatId);
            parameters.Add("include_owner", this.IncludeOwner);
            parameters.Add("page_num", this.PageNum);
            parameters.Add("page_size", this.PageSize);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chat_id", this.ChatId);
            RequestValidator.ValidateMaxLength("chat_id", this.ChatId, 128);
            RequestValidator.ValidateRequired("page_num", this.PageNum);
            RequestValidator.ValidateMinValue("page_num", this.PageNum, 1);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
        }

        #endregion
    }
}
