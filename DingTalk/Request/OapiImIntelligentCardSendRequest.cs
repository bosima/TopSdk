using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.intelligent.card.send
    /// </summary>
    public class OapiImIntelligentCardSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImIntelligentCardSendResponse>
    {
        /// <summary>
        /// 群助理的biz类型
        /// </summary>
        public Nullable<long> BizType { get; set; }

        /// <summary>
        /// 加密的群id
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 动态卡片的json格式模板
        /// </summary>
        public string TemplateData { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.intelligent.card.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("template_data", this.TemplateData);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_type", this.BizType);
            RequestValidator.ValidateRequired("open_conversation_id", this.OpenConversationId);
            RequestValidator.ValidateRequired("template_data", this.TemplateData);
        }

        #endregion
    }
}
