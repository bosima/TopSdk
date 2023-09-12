using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.otoconversation.create
    /// </summary>
    public class OapiImpaasOtoconversationCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasOtoconversationCreateResponse>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string Request { get; set; }

        public CreateO2OSubConversationRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.otoconversation.create";
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
        }

	/// <summary>
/// AccountInfoDomain Data Structure.
/// </summary>
[Serializable]

public class AccountInfoDomain : TopObject
{
	        /// <summary>
	        /// channel名称
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// id类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// CreateO2OSubConversationRequestDomain Data Structure.
/// </summary>
[Serializable]

public class CreateO2OSubConversationRequestDomain : TopObject
{
	        /// <summary>
	        /// 账号列表，size=2。第一个表示自己，第二个表示对方
	        /// </summary>
	        [XmlArray("account_info_list")]
	        [XmlArrayItem("account_info")]
	        public List<AccountInfoDomain> AccountInfoList { get; set; }
	
	        /// <summary>
	        /// channel名称
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 入口id列表，size=2。普通会话填0，二级会话填entrnaceid
	        /// </summary>
	        [XmlArray("entrance_id_list")]
	        [XmlArrayItem("number")]
	        public List<string> EntranceIdList { get; set; }
	
	        /// <summary>
	        /// 扩展信息
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 用于去重和追踪
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

        #endregion
    }
}
