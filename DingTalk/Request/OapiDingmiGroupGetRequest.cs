using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingmi.group.get
    /// </summary>
    public class OapiDingmiGroupGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingmiGroupGetResponse>
    {
        /// <summary>
        /// 会话ID
        /// </summary>
        public string ConversationId { get; set; }

        /// <summary>
        /// ?期(YYYYMMDD格式)
        /// </summary>
        public string Date { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingmi.group.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("conversation_id", this.ConversationId);
            parameters.Add("date", this.Date);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("conversation_id", this.ConversationId);
            RequestValidator.ValidateRequired("date", this.Date);
        }

        #endregion
    }
}
