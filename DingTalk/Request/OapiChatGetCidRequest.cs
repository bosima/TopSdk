using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.get.cid
    /// </summary>
    public class OapiChatGetCidRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatGetCidResponse>
    {
        /// <summary>
        /// 会话Id
        /// </summary>
        public string Chatid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.get.cid";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatid", this.Chatid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatid", this.Chatid);
        }

        #endregion
    }
}
