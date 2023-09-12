using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.getReadList
    /// </summary>
    public class OapiChatGetReadListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatGetReadListResponse>
    {
        /// <summary>
        /// 分页查询的游标，第一次可以传0，后续传返回结果中的next_cursor的值。当返回结果中，没有next_cursor时，表示没有后续的数据了，可以结束调用
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 发送群消息接口返回的加密消息id
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// 分页查询的大小，最大可以传100
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.getReadList";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("messageId", this.MessageId);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
