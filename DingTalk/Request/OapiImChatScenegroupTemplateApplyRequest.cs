using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.scenegroup.template.apply
    /// </summary>
    public class OapiImChatScenegroupTemplateApplyRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatScenegroupTemplateApplyResponse>
    {
        /// <summary>
        /// 启用模式
        /// </summary>
        public Nullable<long> ApplyMode { get; set; }

        /// <summary>
        /// 加密cid,必填
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 群主userid
        /// </summary>
        public string OwnerUserId { get; set; }

        /// <summary>
        /// 群模板ID
        /// </summary>
        public string TemplateId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.scenegroup.template.apply";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("apply_mode", this.ApplyMode);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("owner_user_id", this.OwnerUserId);
            parameters.Add("template_id", this.TemplateId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("open_conversation_id", this.OpenConversationId);
            RequestValidator.ValidateRequired("owner_user_id", this.OwnerUserId);
            RequestValidator.ValidateRequired("template_id", this.TemplateId);
        }

        #endregion
    }
}
