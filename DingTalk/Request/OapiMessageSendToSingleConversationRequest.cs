using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.message.send_to_single_conversation
    /// </summary>
    public class OapiMessageSendToSingleConversationRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMessageSendToSingleConversationResponse>
    {
        /// <summary>
        /// 推送消息内容
        /// </summary>
        public string Msg { get; set; }

        public MsgDomain Msg_ { set { this.Msg = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 接收者userId
        /// </summary>
        public string ReceiverUserid { get; set; }

        /// <summary>
        /// 发送者userId
        /// </summary>
        public string SenderUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.message.send_to_single_conversation";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("msg", this.Msg);
            parameters.Add("receiver_userid", this.ReceiverUserid);
            parameters.Add("sender_userid", this.SenderUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("msg", this.Msg);
            RequestValidator.ValidateRequired("receiver_userid", this.ReceiverUserid);
            RequestValidator.ValidateRequired("sender_userid", this.SenderUserid);
        }

	/// <summary>
/// MarkdownDomain Data Structure.
/// </summary>
[Serializable]

public class MarkdownDomain : TopObject
{
	        /// <summary>
	        /// markdown消息内容
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
}

	/// <summary>
/// MsgDomain Data Structure.
/// </summary>
[Serializable]

public class MsgDomain : TopObject
{
	        /// <summary>
	        /// markdown消息内容
	        /// </summary>
	        [XmlElement("markdown")]
	        public MarkdownDomain Markdown { get; set; }
	
	        /// <summary>
	        /// 消息内容类型,目前只支持markdown
	        /// </summary>
	        [XmlElement("msgtype")]
	        public string Msgtype { get; set; }
}

        #endregion
    }
}
