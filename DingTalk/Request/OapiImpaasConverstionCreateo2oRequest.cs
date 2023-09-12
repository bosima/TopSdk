using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.converstion.createo2o
    /// </summary>
    public class OapiImpaasConverstionCreateo2oRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasConverstionCreateo2oResponse>
    {
        /// <summary>
        /// 创建会话请求
        /// </summary>
        public string Request { get; set; }

        public CreateConversationRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.converstion.createo2o";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// ConversationAccountInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ConversationAccountInfoDomain : TopObject
{
	        /// <summary>
	        /// 创建者账号ID，类型由type字段决定
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 账号ID类型，当type=staff时，id填写staffid，当type=channelUser时，id字段填写channelUserId
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// CreateConversationRequestDomain Data Structure.
/// </summary>
[Serializable]

public class CreateConversationRequestDomain : TopObject
{
	        /// <summary>
	        /// 接入方channel信息，该值由接入方接入IMPaaS平台时，向IMPaaS平台申请，例如“hema”“eleme”等。
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 扩展数据,业务可以自定义，目前最大支持256B
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 接收者
	        /// </summary>
	        [XmlElement("receiver")]
	        public ConversationAccountInfoDomain Receiver { get; set; }
	
	        /// <summary>
	        /// 接收者二级会话入口ID
	        /// </summary>
	        [XmlElement("receiver_entrance_id")]
	        public Nullable<long> ReceiverEntranceId { get; set; }
	
	        /// <summary>
	        /// 发送者
	        /// </summary>
	        [XmlElement("sender")]
	        public ConversationAccountInfoDomain Sender { get; set; }
	
	        /// <summary>
	        /// 发送者二级会话入口ID
	        /// </summary>
	        [XmlElement("sender_entrance_id")]
	        public Nullable<long> SenderEntranceId { get; set; }
	
	        /// <summary>
	        /// uuid, 用于防止弱网情况下超时导致重复创建, 一分钟内传递相同的uuid会返回同一个群，传空则不去重
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

        #endregion
    }
}
