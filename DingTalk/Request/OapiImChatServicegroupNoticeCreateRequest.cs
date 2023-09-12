using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.servicegroup.notice.create
    /// </summary>
    public class OapiImChatServicegroupNoticeCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatServicegroupNoticeCreateResponse>
    {
        /// <summary>
        /// 要创建群公告的群id
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// 是否发送ding提醒
        /// </summary>
        public Nullable<bool> SendDing { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        public Nullable<bool> Sticky { get; set; }

        /// <summary>
        /// 群公告内容
        /// </summary>
        public string TextContent { get; set; }

        /// <summary>
        /// 群公告标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 唯一性key，由调用方提供，避免重复操作。
        /// </summary>
        public string UniqueKey { get; set; }

        /// <summary>
        /// 创建者id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.servicegroup.notice.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chat_id", this.ChatId);
            parameters.Add("send_ding", this.SendDing);
            parameters.Add("sticky", this.Sticky);
            parameters.Add("text_content", this.TextContent);
            parameters.Add("title", this.Title);
            parameters.Add("unique_key", this.UniqueKey);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chat_id", this.ChatId);
            RequestValidator.ValidateRequired("text_content", this.TextContent);
            RequestValidator.ValidateMaxLength("text_content", this.TextContent, 2000);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 200);
            RequestValidator.ValidateRequired("unique_key", this.UniqueKey);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
