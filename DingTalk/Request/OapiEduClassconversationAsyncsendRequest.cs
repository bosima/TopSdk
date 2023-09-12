using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.classconversation.asyncsend
    /// </summary>
    public class OapiEduClassconversationAsyncsendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduClassconversationAsyncsendResponse>
    {
        /// <summary>
        /// request
        /// </summary>
        public string Request { get; set; }

        public TopSendConversationMsgRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.classconversation.asyncsend";
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
/// TopSendConversationMsgRequestDomain Data Structure.
/// </summary>
[Serializable]

public class TopSendConversationMsgRequestDomain : TopObject
{
	        /// <summary>
	        /// 占位符替换词
	        /// </summary>
	        [XmlElement("attributes")]
	        public string Attributes { get; set; }
	
	        /// <summary>
	        /// 班级id
	        /// </summary>
	        [XmlElement("class_id")]
	        public Nullable<long> ClassId { get; set; }
	
	        /// <summary>
	        /// 随机数，在小程序打开的时候传入。需要透传过来
	        /// </summary>
	        [XmlElement("nonce")]
	        public string Nonce { get; set; }
	
	        /// <summary>
	        /// 接收者userid
	        /// </summary>
	        [XmlArray("receiver_user_ids")]
	        [XmlArrayItem("string")]
	        public List<string> ReceiverUserIds { get; set; }
	
	        /// <summary>
	        /// 模板id
	        /// </summary>
	        [XmlElement("template_id")]
	        public Nullable<long> TemplateId { get; set; }
}

        #endregion
    }
}
