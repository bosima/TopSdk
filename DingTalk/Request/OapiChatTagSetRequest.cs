using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.tag.set
    /// </summary>
    public class OapiChatTagSetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatTagSetResponse>
    {
        /// <summary>
        /// 内部群的id
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 群标签的类型。1表示经销群；2表示销管群
        /// </summary>
        public Nullable<long> GroupTag { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.tag.set";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatid", this.Chatid);
            parameters.Add("group_tag", this.GroupTag);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatid", this.Chatid);
            RequestValidator.ValidateRequired("group_tag", this.GroupTag);
        }

        #endregion
    }
}
