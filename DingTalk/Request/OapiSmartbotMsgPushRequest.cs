using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartbot.msg.push
    /// </summary>
    public class OapiSmartbotMsgPushRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartbotMsgPushResponse>
    {
        /// <summary>
        /// 接收者的会话chatid列表
        /// </summary>
        public string ChatIdList { get; set; }

        /// <summary>
        /// 消息体，具体见文档
        /// </summary>
        public string Msg { get; set; }

        public MsgDomain Msg_ { set { this.Msg = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 是否发送给企业全部用户，”true“则忽略用户列表和会话列表
        /// </summary>
        public Nullable<bool> ToAllUser { get; set; }

        /// <summary>
        /// 接收者的用户userid列表
        /// </summary>
        public string UserIdList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartbot.msg.push";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chat_id_list", this.ChatIdList);
            parameters.Add("msg", this.Msg);
            parameters.Add("to_all_user", this.ToAllUser);
            parameters.Add("user_id_list", this.UserIdList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("chat_id_list", this.ChatIdList, 500);
            RequestValidator.ValidateRequired("msg", this.Msg);
            RequestValidator.ValidateMaxListSize("user_id_list", this.UserIdList, 5000);
        }

	/// <summary>
/// TextDomain Data Structure.
/// </summary>
[Serializable]

public class TextDomain : TopObject
{
	        /// <summary>
	        /// 文本消息
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
}

	/// <summary>
/// MarkdownDomain Data Structure.
/// </summary>
[Serializable]

public class MarkdownDomain : TopObject
{
	        /// <summary>
	        /// markdown格式的消息，建议500字符以内
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
	
	        /// <summary>
	        /// 首屏会话透出的展示内容
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// BtnJsonDomain Data Structure.
/// </summary>
[Serializable]

public class BtnJsonDomain : TopObject
{
	        /// <summary>
	        /// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符
	        /// </summary>
	        [XmlElement("action_url")]
	        public string ActionUrl { get; set; }
	
	        /// <summary>
	        /// 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// ActionCardDomain Data Structure.
/// </summary>
[Serializable]

public class ActionCardDomain : TopObject
{
	        /// <summary>
	        /// 使用独立跳转ActionCard样式时的按钮列表；必须与btn_orientation同时设置
	        /// </summary>
	        [XmlArray("btn_json_list")]
	        [XmlArrayItem("btn_json")]
	        public List<BtnJsonDomain> BtnJsonList { get; set; }
	
	        /// <summary>
	        /// 使用独立跳转ActionCard样式时的按钮排列方式，竖直排列(0)，横向排列(1)；必须与btn_json_list同时设置
	        /// </summary>
	        [XmlElement("btn_orientation")]
	        public string BtnOrientation { get; set; }
	
	        /// <summary>
	        /// 消息内容，支持markdown，语法参考标准markdown语法。建议1000个字符以内
	        /// </summary>
	        [XmlElement("markdown")]
	        public string Markdown { get; set; }
	
	        /// <summary>
	        /// 使用整体跳转ActionCard样式时的标题，必须与single_url同时设置，最长20个字符
	        /// </summary>
	        [XmlElement("single_title")]
	        public string SingleTitle { get; set; }
	
	        /// <summary>
	        /// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符
	        /// </summary>
	        [XmlElement("single_url")]
	        public string SingleUrl { get; set; }
	
	        /// <summary>
	        /// 透出到会话列表和通知的文案，最长64个字符
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// MsgDomain Data Structure.
/// </summary>
[Serializable]

public class MsgDomain : TopObject
{
	        /// <summary>
	        /// 卡片消息
	        /// </summary>
	        [XmlElement("action_card")]
	        public ActionCardDomain ActionCard { get; set; }
	
	        /// <summary>
	        /// markdown消息
	        /// </summary>
	        [XmlElement("markdown")]
	        public MarkdownDomain Markdown { get; set; }
	
	        /// <summary>
	        /// 消息类型
	        /// </summary>
	        [XmlElement("msgtype")]
	        public string Msgtype { get; set; }
	
	        /// <summary>
	        /// 文本消息
	        /// </summary>
	        [XmlElement("text")]
	        public TextDomain Text { get; set; }
}

        #endregion
    }
}
