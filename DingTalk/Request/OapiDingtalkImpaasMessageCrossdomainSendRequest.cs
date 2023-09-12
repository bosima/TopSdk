using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingtalk.impaas.message.crossdomain.send
    /// </summary>
    public class OapiDingtalkImpaasMessageCrossdomainSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingtalkImpaasMessageCrossdomainSendResponse>
    {
        /// <summary>
        /// 互通消息结构
        /// </summary>
        public string CrossdomainMessageSendModel { get; set; }

        public TopCrossDomainMessageSendModelDomain CrossdomainMessageSendModel_ { set { this.CrossdomainMessageSendModel = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingtalk.impaas.message.crossdomain.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("crossdomain_message_send_model", this.CrossdomainMessageSendModel);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("crossdomain_message_send_model", this.CrossdomainMessageSendModel);
        }

	/// <summary>
/// TopSendMessageModelDomain Data Structure.
/// </summary>
[Serializable]

public class TopSendMessageModelDomain : TopObject
{
	        /// <summary>
	        /// 会话ID
	        /// </summary>
	        [XmlElement("cid")]
	        public string Cid { get; set; }
	
	        /// <summary>
	        /// 消息内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 消息内容类型1:文本 2:卡片
	        /// </summary>
	        [XmlElement("content_type")]
	        public Nullable<long> ContentType { get; set; }
	
	        /// <summary>
	        /// 会话类型
	        /// </summary>
	        [XmlElement("conversation_type")]
	        public Nullable<long> ConversationType { get; set; }
	
	        /// <summary>
	        /// UUID
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

	/// <summary>
/// MessageReceiverScopeModelDomain Data Structure.
/// </summary>
[Serializable]

public class MessageReceiverScopeModelDomain : TopObject
{
	        /// <summary>
	        /// 接收者
	        /// </summary>
	        [XmlArray("actual_receivers")]
	        [XmlArrayItem("string")]
	        public List<string> ActualReceivers { get; set; }
}

	/// <summary>
/// TopCrossDomainMessageSendModelDomain Data Structure.
/// </summary>
[Serializable]

public class TopCrossDomainMessageSendModelDomain : TopObject
{
	        /// <summary>
	        /// 消息ID
	        /// </summary>
	        [XmlElement("message_id")]
	        public string MessageId { get; set; }
	
	        /// <summary>
	        /// 接收者结构体
	        /// </summary>
	        [XmlElement("message_receiver_scope_model")]
	        public MessageReceiverScopeModelDomain MessageReceiverScopeModel { get; set; }
	
	        /// <summary>
	        /// 会话免打扰，不填或填false为能接收通知；true为开启会话免打扰
	        /// </summary>
	        [XmlElement("new_conversation_notification_off")]
	        public Nullable<bool> NewConversationNotificationOff { get; set; }
	
	        /// <summary>
	        /// 消息发送结构
	        /// </summary>
	        [XmlElement("send_message_model")]
	        public TopSendMessageModelDomain SendMessageModel { get; set; }
	
	        /// <summary>
	        /// 发送者
	        /// </summary>
	        [XmlElement("sender")]
	        public string Sender { get; set; }
}

        #endregion
    }
}
