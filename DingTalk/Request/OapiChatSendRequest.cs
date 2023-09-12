using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.send
    /// </summary>
    public class OapiChatSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatSendResponse>
    {
        /// <summary>
        /// actionCard消息
        /// </summary>
        public string ActionCard { get; set; }

        public ActionCardDomain ActionCard_ { set { this.ActionCard = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 群会话id
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 文件消息
        /// </summary>
        public string File { get; set; }

        public FileDomain File_ { set { this.File = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 图片消息
        /// </summary>
        public string Image { get; set; }

        public ImageDomain Image_ { set { this.Image = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 链接消息
        /// </summary>
        public string Link { get; set; }

        public LinkDomain Link_ { set { this.Link = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// markdown消息
        /// </summary>
        public string Markdown { get; set; }

        public MarkdownDomain Markdown_ { set { this.Markdown = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 消息格式
        /// </summary>
        public string Msg { get; set; }

        public MsgDomain Msg_ { set { this.Msg = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 消息类型
        /// </summary>
        public string Msgtype { get; set; }

        /// <summary>
        /// OA消息
        /// </summary>
        public string Oa { get; set; }

        public OaDomain Oa_ { set { this.Oa = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 文本消息
        /// </summary>
        public string Text { get; set; }

        public TextDomain Text_ { set { this.Text = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 语音消息
        /// </summary>
        public string Voice { get; set; }

        public VoiceDomain Voice_ { set { this.Voice = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("action_card", this.ActionCard);
            parameters.Add("chatid", this.Chatid);
            parameters.Add("file", this.File);
            parameters.Add("image", this.Image);
            parameters.Add("link", this.Link);
            parameters.Add("markdown", this.Markdown);
            parameters.Add("msg", this.Msg);
            parameters.Add("msgtype", this.Msgtype);
            parameters.Add("oa", this.Oa);
            parameters.Add("text", this.Text);
            parameters.Add("voice", this.Voice);
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
/// BtnJsonDomain Data Structure.
/// </summary>
[Serializable]

public class BtnJsonDomain : TopObject
{
	        /// <summary>
	        /// 使用独立跳转ActionCard样式时的按钮的链接url
	        /// </summary>
	        [XmlElement("action_url")]
	        public string ActionUrl { get; set; }
	
	        /// <summary>
	        /// 使用独立跳转ActionCard样式时的按钮的标题
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
	        /// 可选，微应用agentid。默认在角标处显示企业的名称和图标，如果传入agentid则在角标处显示微应用的名称和图标
	        /// </summary>
	        [XmlElement("agentid")]
	        public string Agentid { get; set; }
	
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
	        /// 是否隐藏发送者头像
	        /// </summary>
	        [XmlElement("hide_avatar")]
	        public Nullable<bool> HideAvatar { get; set; }
	
	        /// <summary>
	        /// 消息内容
	        /// </summary>
	        [XmlElement("markdown")]
	        public string Markdown { get; set; }
	
	        /// <summary>
	        /// 使用整体跳转ActionCard样式时的标题，必须与single_url同时设置
	        /// </summary>
	        [XmlElement("single_title")]
	        public string SingleTitle { get; set; }
	
	        /// <summary>
	        /// 使用整体跳转ActionCard样式时的链接url，必须与single_title同时设置
	        /// </summary>
	        [XmlElement("single_url")]
	        public string SingleUrl { get; set; }
	
	        /// <summary>
	        /// 透出到会话列表和通知的文案
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// HeadDomain Data Structure.
/// </summary>
[Serializable]

public class HeadDomain : TopObject
{
	        /// <summary>
	        /// 消息头部背景颜色
	        /// </summary>
	        [XmlElement("bgcolor")]
	        public string Bgcolor { get; set; }
	
	        /// <summary>
	        /// 消息头部标题
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
}

	/// <summary>
/// RichDomain Data Structure.
/// </summary>
[Serializable]

public class RichDomain : TopObject
{
	        /// <summary>
	        /// 单行富文本信息的单位
	        /// </summary>
	        [XmlElement("num")]
	        public string Num { get; set; }
	
	        /// <summary>
	        /// 单行富文本信息的数目
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
}

	/// <summary>
/// FormDomain Data Structure.
/// </summary>
[Serializable]

public class FormDomain : TopObject
{
	        /// <summary>
	        /// 消息体的关键字
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 消息体的关键字对应的值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// BodyDomain Data Structure.
/// </summary>
[Serializable]

public class BodyDomain : TopObject
{
	        /// <summary>
	        /// 自定义的作者名字
	        /// </summary>
	        [XmlElement("author")]
	        public string Author { get; set; }
	
	        /// <summary>
	        /// 消息体的内容，最多显示3行
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 自定义的附件数目。此数字仅供显示，钉钉不作验证
	        /// </summary>
	        [XmlElement("file_count")]
	        public string FileCount { get; set; }
	
	        /// <summary>
	        /// 消息体的表单，最多显示6个，超过会被隐藏
	        /// </summary>
	        [XmlArray("form")]
	        [XmlArrayItem("form")]
	        public List<FormDomain> Form { get; set; }
	
	        /// <summary>
	        /// 消息体中的图片media_id
	        /// </summary>
	        [XmlElement("image")]
	        public string Image { get; set; }
	
	        /// <summary>
	        /// 单行富文本信息
	        /// </summary>
	        [XmlElement("rich")]
	        public RichDomain Rich { get; set; }
	
	        /// <summary>
	        /// 消息体的标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// OaDomain Data Structure.
/// </summary>
[Serializable]

public class OaDomain : TopObject
{
	        /// <summary>
	        /// 消息体
	        /// </summary>
	        [XmlElement("body")]
	        public BodyDomain Body { get; set; }
	
	        /// <summary>
	        /// 消息头部
	        /// </summary>
	        [XmlElement("head")]
	        public HeadDomain Head { get; set; }
	
	        /// <summary>
	        /// 消息链接
	        /// </summary>
	        [XmlElement("message_url")]
	        public string MessageUrl { get; set; }
	
	        /// <summary>
	        /// pc端消息链接
	        /// </summary>
	        [XmlElement("pc_message_url")]
	        public string PcMessageUrl { get; set; }
}

	/// <summary>
/// VoiceDomain Data Structure.
/// </summary>
[Serializable]

public class VoiceDomain : TopObject
{
	        /// <summary>
	        /// 语音正整数，小于60，表示音频时长长
	        /// </summary>
	        [XmlElement("duration")]
	        public Nullable<long> Duration { get; set; }
	
	        /// <summary>
	        /// 语音mediaId
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
}

	/// <summary>
/// FileDomain Data Structure.
/// </summary>
[Serializable]

public class FileDomain : TopObject
{
	        /// <summary>
	        /// 文件mediaId
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
}

	/// <summary>
/// ImageDomain Data Structure.
/// </summary>
[Serializable]

public class ImageDomain : TopObject
{
	        /// <summary>
	        /// 图片mediaId
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
}

	/// <summary>
/// LinkDomain Data Structure.
/// </summary>
[Serializable]

public class LinkDomain : TopObject
{
	        /// <summary>
	        /// 消息点击链接地址
	        /// </summary>
	        [XmlElement("messageUrl")]
	        public string MessageUrl { get; set; }
	
	        /// <summary>
	        /// 图片地址
	        /// </summary>
	        [XmlElement("picUrl")]
	        public string PicUrl { get; set; }
	
	        /// <summary>
	        /// 消息文本
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
/// TextDomain Data Structure.
/// </summary>
[Serializable]

public class TextDomain : TopObject
{
	        /// <summary>
	        /// 文本消息内容
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
/// BtnJsonListDomain Data Structure.
/// </summary>
[Serializable]

public class BtnJsonListDomain : TopObject
{
	        /// <summary>
	        /// 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符
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
/// MsgDomain Data Structure.
/// </summary>
[Serializable]

public class MsgDomain : TopObject
{
	        /// <summary>
	        /// action_card卡片消息
	        /// </summary>
	        [XmlElement("action_card")]
	        public ActionCardDomain ActionCard { get; set; }
	
	        /// <summary>
	        /// 文件消息
	        /// </summary>
	        [XmlElement("file")]
	        public FileDomain File { get; set; }
	
	        /// <summary>
	        /// 图片消息
	        /// </summary>
	        [XmlElement("image")]
	        public ImageDomain Image { get; set; }
	
	        /// <summary>
	        /// link消息
	        /// </summary>
	        [XmlElement("link")]
	        public LinkDomain Link { get; set; }
	
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
	        /// oa消息
	        /// </summary>
	        [XmlElement("oa")]
	        public OaDomain Oa { get; set; }
	
	        /// <summary>
	        /// 文本消息
	        /// </summary>
	        [XmlElement("text")]
	        public TextDomain Text { get; set; }
	
	        /// <summary>
	        /// 语音消息
	        /// </summary>
	        [XmlElement("voice")]
	        public VoiceDomain Voice { get; set; }
}

        #endregion
    }
}
