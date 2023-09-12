using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.chatbot.install
    /// </summary>
    public class CorpChatbotInstallRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpChatbotInstallResponse>
    {
        /// <summary>
        /// 安装的机器人信息
        /// </summary>
        public string ChatbotVo { get; set; }

        public ChatbotVoDomain ChatbotVo_ { set { this.ChatbotVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.chatbot.install";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatbot_vo", this.ChatbotVo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatbot_vo", this.ChatbotVo);
        }

	/// <summary>
/// ChatbotVoDomain Data Structure.
/// </summary>
[Serializable]

public class ChatbotVoDomain : TopObject
{
	        /// <summary>
	        /// 0-正常，1-只服务端可管理
	        /// </summary>
	        [XmlElement("authority")]
	        public Nullable<long> Authority { get; set; }
	
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
	        /// 机器人id(钉钉分配)
	        /// </summary>
	        [XmlElement("chatbot_id")]
	        public string ChatbotId { get; set; }
	
	        /// <summary>
	        /// 机器详细介绍
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// INCOMING = 1,OUTGOING  = 2,INOUT     = 3
	        /// </summary>
	        [XmlElement("function")]
	        public Nullable<long> Function { get; set; }
	
	        /// <summary>
	        /// 机器人头像mediaId
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 向群添加机器人时是否可改头像：0-不可必，1-可改
	        /// </summary>
	        [XmlElement("icon_mdify")]
	        public Nullable<long> IconMdify { get; set; }
	
	        /// <summary>
	        /// 手机端是否能添加机器人：0-移动端不能加，1-移动端能添加
	        /// </summary>
	        [XmlElement("mobile_switch")]
	        public Nullable<long> MobileSwitch { get; set; }
	
	        /// <summary>
	        /// 机器人的名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 向群添加机器人时是否可改名字：0-不可必，1-可改
	        /// </summary>
	        [XmlElement("name_modify")]
	        public Nullable<long> NameModify { get; set; }
	
	        /// <summary>
	        /// 是否支持单聊：0-不要单聊，1需要单聊
	        /// </summary>
	        [XmlElement("oto_support")]
	        public Nullable<long> OtoSupport { get; set; }
	
	        /// <summary>
	        /// 机器人消息回调时在header中添加的token,用于对钉钉鉴权
	        /// </summary>
	        [XmlElement("outgoing_token")]
	        public string OutgoingToken { get; set; }
	
	        /// <summary>
	        /// 机器人回调URL
	        /// </summary>
	        [XmlElement("outgoing_url")]
	        public string OutgoingUrl { get; set; }
	
	        /// <summary>
	        /// 机器人预览图
	        /// </summary>
	        [XmlElement("preview_media_id")]
	        public string PreviewMediaId { get; set; }
}

        #endregion
    }
}
