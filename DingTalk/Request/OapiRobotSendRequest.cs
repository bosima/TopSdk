using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.robot.send
    /// </summary>
    public class OapiRobotSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRobotSendResponse>
    {
        /// <summary>
        /// 此消息类型为固定actionCard
        /// </summary>
        public string ActionCard { get; set; }

        public ActioncardDomain ActionCard_ { set { this.ActionCard = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 被@人的手机号
        /// </summary>
        public string At { get; set; }

        public AtDomain At_ { set { this.At = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 此消息类型为固定feedCard
        /// </summary>
        public string FeedCard { get; set; }

        public FeedcardDomain FeedCard_ { set { this.FeedCard = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 消息类型，此时固定为:link
        /// </summary>
        public string Link { get; set; }

        public LinkDomain Link_ { set { this.Link = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 此消息类型为固定markdown
        /// </summary>
        public string Markdown { get; set; }

        public MarkdownDomain Markdown_ { set { this.Markdown = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 消息类型
        /// </summary>
        public string Msgtype { get; set; }

        /// <summary>
        /// text类型
        /// </summary>
        public string Text { get; set; }

        public TextDomain Text_ { set { this.Text = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.robot.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("actionCard", this.ActionCard);
            parameters.Add("at", this.At);
            parameters.Add("feedCard", this.FeedCard);
            parameters.Add("link", this.Link);
            parameters.Add("markdown", this.Markdown);
            parameters.Add("msgtype", this.Msgtype);
            parameters.Add("text", this.Text);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("msgtype", this.Msgtype);
        }

	/// <summary>
/// TextDomain Data Structure.
/// </summary>
[Serializable]

public class TextDomain : TopObject
{
	        /// <summary>
	        /// text类型
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
}

	/// <summary>
/// AtDomain Data Structure.
/// </summary>
[Serializable]

public class AtDomain : TopObject
{
	        /// <summary>
	        /// 被@人的手机号
	        /// </summary>
	        [XmlArray("atMobiles")]
	        [XmlArrayItem("string")]
	        public List<string> AtMobiles { get; set; }
	
	        /// <summary>
	        /// 被@人的工号
	        /// </summary>
	        [XmlArray("atUserIds")]
	        [XmlArrayItem("string")]
	        public List<string> AtUserIds { get; set; }
	
	        /// <summary>
	        /// @所有人时:true,否则为:false
	        /// </summary>
	        [XmlElement("isAtAll")]
	        public Nullable<bool> IsAtAll { get; set; }
}

	/// <summary>
/// LinkDomain Data Structure.
/// </summary>
[Serializable]

public class LinkDomain : TopObject
{
	        /// <summary>
	        /// 点击消息跳转的URL
	        /// </summary>
	        [XmlElement("messageUrl")]
	        public string MessageUrl { get; set; }
	
	        /// <summary>
	        /// 图片URL
	        /// </summary>
	        [XmlElement("picUrl")]
	        public string PicUrl { get; set; }
	
	        /// <summary>
	        /// 消息内容。如果太长只会部分展示
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
	
	        /// <summary>
	        /// 消息标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// MarkdownDomain Data Structure.
/// </summary>
[Serializable]

public class MarkdownDomain : TopObject
{
	        /// <summary>
	        /// markdown格式的消息
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
/// BtnsDomain Data Structure.
/// </summary>
[Serializable]

public class BtnsDomain : TopObject
{
	        /// <summary>
	        /// 按钮方案，
	        /// </summary>
	        [XmlElement("actionURL")]
	        public string ActionURL { get; set; }
	
	        /// <summary>
	        /// 点击按钮触发的URL此消息类型为固定feedCard
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// ActioncardDomain Data Structure.
/// </summary>
[Serializable]

public class ActioncardDomain : TopObject
{
	        /// <summary>
	        /// 0-按钮竖直排列，1-按钮横向排列
	        /// </summary>
	        [XmlElement("btnOrientation")]
	        public string BtnOrientation { get; set; }
	
	        /// <summary>
	        /// 按钮的信息
	        /// </summary>
	        [XmlArray("btns")]
	        [XmlArrayItem("btns")]
	        public List<BtnsDomain> Btns { get; set; }
	
	        /// <summary>
	        /// 0-正常发消息者头像,1-隐藏发消息者头像
	        /// </summary>
	        [XmlElement("hideAvatar")]
	        public string HideAvatar { get; set; }
	
	        /// <summary>
	        /// 单个按钮的方案。(设置此项和singleURL后btns无效。)
	        /// </summary>
	        [XmlElement("singleTitle")]
	        public string SingleTitle { get; set; }
	
	        /// <summary>
	        /// 点击singleTitle按钮触发的URL
	        /// </summary>
	        [XmlElement("singleURL")]
	        public string SingleURL { get; set; }
	
	        /// <summary>
	        /// markdown格式的消息
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
/// LinksDomain Data Structure.
/// </summary>
[Serializable]

public class LinksDomain : TopObject
{
	        /// <summary>
	        /// 点击单条信息到跳转链接
	        /// </summary>
	        [XmlElement("messageURL")]
	        public string MessageURL { get; set; }
	
	        /// <summary>
	        /// 单条信息文本
	        /// </summary>
	        [XmlElement("picURL")]
	        public string PicURL { get; set; }
	
	        /// <summary>
	        /// 单条信息后面图片的URL
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// FeedcardDomain Data Structure.
/// </summary>
[Serializable]

public class FeedcardDomain : TopObject
{
	        /// <summary>
	        /// links
	        /// </summary>
	        [XmlArray("links")]
	        [XmlArrayItem("links")]
	        public List<LinksDomain> Links { get; set; }
}

        #endregion
    }
}
