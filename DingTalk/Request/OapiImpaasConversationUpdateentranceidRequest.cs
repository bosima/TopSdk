using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.conversation.updateentranceid
    /// </summary>
    public class OapiImpaasConversationUpdateentranceidRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasConversationUpdateentranceidResponse>
    {
        /// <summary>
        /// 参数结构体
        /// </summary>
        public string Request { get; set; }

        public UpdateEntranceIdRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.conversation.updateentranceid";
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
	        /// 账号通道:eleme,hema等
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 账号ID
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 账号类型:channelUser/staff。当类型为channelUser时，填写app自己的账号，当类型为staff时，填写钉钉的staffid
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// UpdateEntranceIdRequestDomain Data Structure.
/// </summary>
[Serializable]

public class UpdateEntranceIdRequestDomain : TopObject
{
	        /// <summary>
	        /// 要设置的用户列表
	        /// </summary>
	        [XmlArray("accounts")]
	        [XmlArrayItem("account_info")]
	        public List<AccountInfoDomain> Accounts { get; set; }
	
	        /// <summary>
	        /// 业务channel
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 会话id
	        /// </summary>
	        [XmlElement("cid")]
	        public string Cid { get; set; }
	
	        /// <summary>
	        /// 入口id，数字
	        /// </summary>
	        [XmlElement("entrance_id")]
	        public Nullable<long> EntranceId { get; set; }
	
	        /// <summary>
	        /// 扩展信息，可选
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 该请求的唯一id，用于去重、打日志
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

        #endregion
    }
}
