using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.message.getmessage
    /// </summary>
    public class OapiImpaasMessageGetmessageRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasMessageGetmessageResponse>
    {
        /// <summary>
        /// 请求信息
        /// </summary>
        public string Request { get; set; }

        public GetMessageRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.message.getmessage";
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
	        /// 业务对应的通道信息
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 根据type类型确定
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// staff:表示使用钉钉的员工账号，channelUser：表示业务自己的账号
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// GetMessageRequestDomain Data Structure.
/// </summary>
[Serializable]

public class GetMessageRequestDomain : TopObject
{
	        /// <summary>
	        /// 从什么时候开始查，utc时间，单位毫秒
	        /// </summary>
	        [XmlElement("beg_time")]
	        public Nullable<long> BegTime { get; set; }
	
	        /// <summary>
	        /// 群id
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// 获取的消息数量，总的数量小于需要获取的数量时，返回实际的消息数量.1-20之间
	        /// </summary>
	        [XmlElement("limit_num")]
	        public Nullable<long> LimitNum { get; set; }
	
	        /// <summary>
	        /// 单聊消息时使用，暂时不支持，可以不填
	        /// </summary>
	        [XmlElement("receiver_id")]
	        public AccountInfoDomain ReceiverId { get; set; }
	
	        /// <summary>
	        /// 单聊消息时使用，暂时不支持，可以不填
	        /// </summary>
	        [XmlElement("sender_id")]
	        public AccountInfoDomain SenderId { get; set; }
}

        #endregion
    }
}
