using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.servicegroup.message.send
    /// </summary>
    public class OapiServicegroupMessageSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiServicegroupMessageSendResponse>
    {
        /// <summary>
        /// 消息对象
        /// </summary>
        public string ConversationMessage { get; set; }

        public ConversationMessageDomain ConversationMessage_ { set { this.ConversationMessage = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 订单id
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.servicegroup.message.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("conversation_message", this.ConversationMessage);
            parameters.Add("order_id", this.OrderId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("conversation_message", this.ConversationMessage);
            RequestValidator.ValidateRequired("order_id", this.OrderId);
        }

	/// <summary>
/// ConversationMessageDomain Data Structure.
/// </summary>
[Serializable]

public class ConversationMessageDomain : TopObject
{
	        /// <summary>
	        /// 内容
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

        #endregion
    }
}
