using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.message.send_to_conversation
    /// </summary>
    public class OapiMessageSendToConversationRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMessageSendToConversationResponse>
    {
        /// <summary>
        /// ActionCard消息
        /// </summary>
        public string ActionCard { get; set; }

        public ActionCardDomain ActionCard_ { set { this.ActionCard = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 群消息或者个人聊天会话Id，(通过JSAPI之pickConversation接口唤起联系人界面选择之后即可拿到会话ID，之后您可以使用获取到的cid调用此接口）
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// file消息
        /// </summary>
        public string File { get; set; }

        public FileDomain File_ { set { this.File = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// image消息
        /// </summary>
        public string Image { get; set; }

        public ImageDomain Image_ { set { this.Image = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// link消息
        /// </summary>
        public string Link { get; set; }

        public LinkDomain Link_ { set { this.Link = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// markdown消息
        /// </summary>
        public string Markdown { get; set; }

        public MarkdownDomain Markdown_ { set { this.Markdown = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 消息内容
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
        /// 消息发送者员工ID
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// text消息
        /// </summary>
        public string Text { get; set; }

        public TextDomain Text_ { set { this.Text = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// voice消息
        /// </summary>
        public string Voice { get; set; }

        public VoiceDomain Voice_ { set { this.Voice = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.message.send_to_conversation";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("action_card", this.ActionCard);
            parameters.Add("cid", this.Cid);
            parameters.Add("file", this.File);
            parameters.Add("image", this.Image);
            parameters.Add("link", this.Link);
            parameters.Add("markdown", this.Markdown);
            parameters.Add("msg", this.Msg);
            parameters.Add("msgtype", this.Msgtype);
            parameters.Add("oa", this.Oa);
            parameters.Add("sender", this.Sender);
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
/// FormDomain Data Structure.
/// </summary>
[Serializable]

public class FormDomain : TopObject
{
	        /// <summary>
	        /// 消息体的关键字对应的值
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 消息体的关键字
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// RichDomain Data Structure.
/// </summary>
[Serializable]

public class RichDomain : TopObject
{
	        /// <summary>
	        /// 单行富文本信息的数目
	        /// </summary>
	        [XmlElement("num")]
	        public string Num { get; set; }
	
	        /// <summary>
	        /// 单行富文本信息的单位
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
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
	        /// 消息体中的图片，支持图片资源@mediaId
	        /// </summary>
	        [XmlElement("image")]
	        public string Image { get; set; }
	
	        /// <summary>
	        /// 单行富文本信息
	        /// </summary>
	        [XmlElement("rich")]
	        public RichDomain Rich { get; set; }
	
	        /// <summary>
	        /// 消息体的标题，建议50个字符以内
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
	        /// 消息头部的背景颜色。长度限制为8个英文字符，其中前2为表示透明度，后6位表示颜色值。不要添加0x
	        /// </summary>
	        [XmlElement("bgcolor")]
	        public string Bgcolor { get; set; }
	
	        /// <summary>
	        /// 消息的头部标题 (向普通会话发送时有效，向企业会话发送时会被替换为微应用的名字)，长度限制为最多10个字符
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
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
	        /// 消息头部内容
	        /// </summary>
	        [XmlElement("head")]
	        public HeadDomain Head { get; set; }
	
	        /// <summary>
	        /// 客户端点击消息时跳转到的H5地址
	        /// </summary>
	        [XmlElement("message_url")]
	        public string MessageUrl { get; set; }
	
	        /// <summary>
	        /// PC端点击消息时跳转到的地址
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
	        /// 语音时长
	        /// </summary>
	        [XmlElement("duration")]
	        public Nullable<long> Duration { get; set; }
	
	        /// <summary>
	        /// 语音媒体文件id，可以调用上传媒体文件接口获取。2MB，播放长度不超过60s，AMR格式
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
	        /// 媒体文件id，可以调用上传媒体文件接口获取。10MB
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
	        /// 图片媒体文件id，可以调用上传媒体文件接口获取
	        /// </summary>
	        [XmlElement("picUrl")]
	        public string PicUrl { get; set; }
	
	        /// <summary>
	        /// 消息描述
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
/// ImageDomain Data Structure.
/// </summary>
[Serializable]

public class ImageDomain : TopObject
{
	        /// <summary>
	        /// 图片媒体文件id，可以调用上传媒体文件接口获取。建议宽600像素 x 400像素，宽高比3：2
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
}

	/// <summary>
/// TextDomain Data Structure.
/// </summary>
[Serializable]

public class TextDomain : TopObject
{
	        /// <summary>
	        /// 消息内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
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
	        /// 消息内容，支持markdown，语法参考标准markdown语法。图片举例：![alt text](mediaId)
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
/// MsgDomain Data Structure.
/// </summary>
[Serializable]

public class MsgDomain : TopObject
{
	        /// <summary>
	        /// 消息内容，支持markdown，语法参考标准markdown语法。图片举例：![alt text](mediaId)
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
	        /// 链接消息
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
