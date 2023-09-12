using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.chatbot.createorgbot
    /// </summary>
    public class CorpChatbotCreateorgbotRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpChatbotCreateorgbotResponse>
    {
        /// <summary>
        /// 创建机器人modle
        /// </summary>
        public string CreateChatBotModel { get; set; }

        public CreateChatBotModelDomain CreateChatBotModel_ { set { this.CreateChatBotModel = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.chatbot.createorgbot";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("create_chat_bot_model", this.CreateChatBotModel);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("create_chat_bot_model", this.CreateChatBotModel);
        }

	/// <summary>
/// CreateChatBotModelDomain Data Structure.
/// </summary>
[Serializable]

public class CreateChatBotModelDomain : TopObject
{
	        /// <summary>
	        /// 2-企业对内机器人，3-企业对外机器人
	        /// </summary>
	        [XmlElement("bot_type")]
	        public Nullable<long> BotType { get; set; }
	
	        /// <summary>
	        /// 机器人简介
	        /// </summary>
	        [XmlElement("breif")]
	        public string Breif { get; set; }
	
	        /// <summary>
	        /// 开通机器人企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 机器人功能详细描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 机器人头像
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 微应用id
	        /// </summary>
	        [XmlElement("microapp_agent_id")]
	        public Nullable<long> MicroappAgentId { get; set; }
	
	        /// <summary>
	        /// 机器人名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 机器人安全秘钥
	        /// </summary>
	        [XmlElement("outgoing_token")]
	        public string OutgoingToken { get; set; }
	
	        /// <summary>
	        /// 机器人回调URL
	        /// </summary>
	        [XmlElement("outgoing_url")]
	        public string OutgoingUrl { get; set; }
	
	        /// <summary>
	        /// 机器人类型(钉钉分配)
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

        #endregion
    }
}
