using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.message.getmessagestatus
    /// </summary>
    public class OapiImpaasMessageGetmessagestatusRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasMessageGetmessagestatusResponse>
    {
        /// <summary>
        /// 根据异步发送时返回的taskid获取消息
        /// </summary>
        public string Request { get; set; }

        public GetMessageStatusRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.message.getmessagestatus";
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
/// AccountInfoDomain Data Structure.
/// </summary>
[Serializable]

public class AccountInfoDomain : TopObject
{
	        /// <summary>
	        /// 账号的通道
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 账号ID
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 账号的类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// GetMessageStatusRequestDomain Data Structure.
/// </summary>
[Serializable]

public class GetMessageStatusRequestDomain : TopObject
{
	        /// <summary>
	        /// 账号信息
	        /// </summary>
	        [XmlElement("senderid")]
	        public AccountInfoDomain Senderid { get; set; }
	
	        /// <summary>
	        /// 异步返回的任务ID
	        /// </summary>
	        [XmlElement("taskid")]
	        public Nullable<long> Taskid { get; set; }
}

        #endregion
    }
}
