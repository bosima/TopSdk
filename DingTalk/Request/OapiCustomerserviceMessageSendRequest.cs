using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.customerservice.message.send
    /// </summary>
    public class OapiCustomerserviceMessageSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCustomerserviceMessageSendResponse>
    {
        /// <summary>
        /// 消息对象
        /// </summary>
        public string Message { get; set; }

        public MessageDTODomain Message_ { set { this.Message = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.customerservice.message.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("message", this.Message);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("message", this.Message);
        }

	/// <summary>
/// MessageDTODomain Data Structure.
/// </summary>
[Serializable]

public class MessageDTODomain : TopObject
{
	        /// <summary>
	        /// 会员所属组织
	        /// </summary>
	        [XmlElement("bu_id")]
	        public string BuId { get; set; }
	
	        /// <summary>
	        /// 会员id
	        /// </summary>
	        [XmlElement("cms_id")]
	        public string CmsId { get; set; }
	
	        /// <summary>
	        /// 消息内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// /**      * 文本      */     TEXT(1),      /**      * 图片      */     IMAGE(2),      /**      * 视频      */     VIDEO(3),      /**      * 链接      */     LINK(4),      /**      * 语音      */     VOICE(5),      /**      * markdown      */     MARK_DOWN(6),      /**      * 交互式卡片      */     ACTION_CARD(7),      /**      * 富文本      */     RICH_TEXT(8),      /**      * 文件      */     FILE(9),      /**      * 消息已读      */     MSG_READ(10)
	        /// </summary>
	        [XmlElement("content_type")]
	        public Nullable<long> ContentType { get; set; }
	
	        /// <summary>
	        /// 钉钉的企业id
	        /// </summary>
	        [XmlElement("ding_corp_id")]
	        public string DingCorpId { get; set; }
	
	        /// <summary>
	        /// 消息生成时间
	        /// </summary>
	        [XmlElement("message_create_at")]
	        public Nullable<long> MessageCreateAt { get; set; }
	
	        /// <summary>
	        /// 消息id
	        /// </summary>
	        [XmlElement("message_id")]
	        public string MessageId { get; set; }
	
	        /// <summary>
	        /// 实例id
	        /// </summary>
	        [XmlElement("open_instance_id")]
	        public string OpenInstanceId { get; set; }
	
	        /// <summary>
	        /// 1，智能客服；1001，经济体智能客服
	        /// </summary>
	        [XmlElement("production_type")]
	        public Nullable<long> ProductionType { get; set; }
	
	        /// <summary>
	        /// 小二serviceId，或者会员的cmsId
	        /// </summary>
	        [XmlElement("sender_id")]
	        public string SenderId { get; set; }
	
	        /// <summary>
	        /// 4，小二；1，会员
	        /// </summary>
	        [XmlElement("sender_type")]
	        public string SenderType { get; set; }
	
	        /// <summary>
	        /// 会话来源
	        /// </summary>
	        [XmlElement("session_source")]
	        public string SessionSource { get; set; }
	
	        /// <summary>
	        /// 会话id
	        /// </summary>
	        [XmlElement("sid")]
	        public string Sid { get; set; }
}

        #endregion
    }
}
