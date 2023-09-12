using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.qrcode.get
    /// </summary>
    public class OapiChatQrcodeGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatQrcodeGetResponse>
    {
        /// <summary>
        /// 会话id（逐步淘汰推荐使用openConversationId)
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 开放群id（与会话id 二选一）
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 分享二维码用户id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.qrcode.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatid", this.Chatid);
            parameters.Add("openConversationId", this.OpenConversationId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
