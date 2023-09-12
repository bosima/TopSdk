using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingtalk.impaas.message.crossdomain.read
    /// </summary>
    public class OapiDingtalkImpaasMessageCrossdomainReadRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingtalkImpaasMessageCrossdomainReadResponse>
    {
        /// <summary>
        /// 消息已读结构
        /// </summary>
        public string MessageReadModel { get; set; }

        public TopCrossDomainMessageReadModelDomain MessageReadModel_ { set { this.MessageReadModel = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingtalk.impaas.message.crossdomain.read";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("message_read_model", this.MessageReadModel);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("message_read_model", this.MessageReadModel);
        }

	/// <summary>
/// TopCrossDomainMessageReadModelDomain Data Structure.
/// </summary>
[Serializable]

public class TopCrossDomainMessageReadModelDomain : TopObject
{
	        /// <summary>
	        /// 消息ID列表
	        /// </summary>
	        [XmlArray("message_ids")]
	        [XmlArrayItem("string")]
	        public List<string> MessageIds { get; set; }
	
	        /// <summary>
	        /// 操作者ID
	        /// </summary>
	        [XmlElement("operator_uid")]
	        public string OperatorUid { get; set; }
}

        #endregion
    }
}
