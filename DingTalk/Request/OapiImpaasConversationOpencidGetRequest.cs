using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.conversation.opencid.get
    /// </summary>
    public class OapiImpaasConversationOpencidGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasConversationOpencidGetResponse>
    {
        /// <summary>
        /// 基础会话对象
        /// </summary>
        public string Model { get; set; }

        public CrossDomainBaseConversationModelDomain Model_ { set { this.Model = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.conversation.opencid.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("model", this.Model);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("model", this.Model);
        }

	/// <summary>
/// CrossDomainBaseConversationModelDomain Data Structure.
/// </summary>
[Serializable]

public class CrossDomainBaseConversationModelDomain : TopObject
{
	        /// <summary>
	        /// 会话id
	        /// </summary>
	        [XmlElement("cid")]
	        public string Cid { get; set; }
	
	        /// <summary>
	        /// 会话类型
	        /// </summary>
	        [XmlElement("conversation_type")]
	        public Nullable<long> ConversationType { get; set; }
}

        #endregion
    }
}
