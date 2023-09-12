using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.message.mass.send
    /// </summary>
    public class OapiMessageMassSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMessageMassSendResponse>
    {
        /// <summary>
        /// 接收者的部门id列表，接收者是部门id下(包括子部门下)的所有用户
        /// </summary>
        public string DepIdList { get; set; }

        /// <summary>
        /// 是否预览推送
        /// </summary>
        public Nullable<bool> IsPreview { get; set; }

        /// <summary>
        /// 是否群发给所有订阅者，true-是，false-否
        /// </summary>
        public Nullable<bool> IsToAll { get; set; }

        /// <summary>
        /// 消息卡片素材id
        /// </summary>
        public string MediaId { get; set; }

        /// <summary>
        /// 消息体
        /// </summary>
        public string MsgBody { get; set; }

        public MessageBodyDomain MsgBody_ { set { this.MsgBody = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// msg_type, 消息类型：text，文本类型，此时文本内容填在text_content字段中；news_card，消息卡片，此时的media_id通过消息卡片上传接口得到； image，图片，此时的media_id通过图片上传接口得到
        /// </summary>
        public string MsgType { get; set; }

        /// <summary>
        /// 文本内容，当msg_type为text时有效
        /// </summary>
        public string TextContent { get; set; }

        /// <summary>
        /// 服务号的unionid
        /// </summary>
        public string Unionid { get; set; }

        /// <summary>
        /// 接收者的用户userid列表
        /// </summary>
        public string UseridList { get; set; }

        /// <summary>
        /// 调用时填写随机生成的UUID, 防止消息重复发送
        /// </summary>
        public string Uuid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.message.mass.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dep_id_list", this.DepIdList);
            parameters.Add("is_preview", this.IsPreview);
            parameters.Add("is_to_all", this.IsToAll);
            parameters.Add("media_id", this.MediaId);
            parameters.Add("msg_body", this.MsgBody);
            parameters.Add("msg_type", this.MsgType);
            parameters.Add("text_content", this.TextContent);
            parameters.Add("unionid", this.Unionid);
            parameters.Add("userid_list", this.UseridList);
            parameters.Add("uuid", this.Uuid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("dep_id_list", this.DepIdList, 2000);
            RequestValidator.ValidateRequired("is_to_all", this.IsToAll);
            RequestValidator.ValidateMaxLength("media_id", this.MediaId, 256);
            RequestValidator.ValidateRequired("msg_type", this.MsgType);
            RequestValidator.ValidateMaxLength("msg_type", this.MsgType, 32);
            RequestValidator.ValidateMaxLength("text_content", this.TextContent, 65535);
            RequestValidator.ValidateRequired("unionid", this.Unionid);
            RequestValidator.ValidateMaxLength("unionid", this.Unionid, 128);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 10000);
            RequestValidator.ValidateRequired("uuid", this.Uuid);
            RequestValidator.ValidateMaxLength("uuid", this.Uuid, 128);
        }

	/// <summary>
/// VoiceDomain Data Structure.
/// </summary>
[Serializable]

public class VoiceDomain : TopObject
{
	        /// <summary>
	        /// 正整数，小于60，表示音频时长
	        /// </summary>
	        [XmlElement("duration")]
	        public Nullable<long> Duration { get; set; }
	
	        /// <summary>
	        /// 媒体文件id。2MB，播放长度不超过60s，AMR格式
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
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
/// FormItemDomain Data Structure.
/// </summary>
[Serializable]

public class FormItemDomain : TopObject
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
/// RichTextDomain Data Structure.
/// </summary>
[Serializable]

public class RichTextDomain : TopObject
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
	        public Nullable<long> FileCount { get; set; }
	
	        /// <summary>
	        /// 消息体的表单，最多显示6个，超过会被隐藏
	        /// </summary>
	        [XmlArray("form")]
	        [XmlArrayItem("form_item")]
	        public List<FormItemDomain> Form { get; set; }
	
	        /// <summary>
	        /// 消息体中的图片，支持图片资源@mediaId
	        /// </summary>
	        [XmlElement("image")]
	        public string Image { get; set; }
	
	        /// <summary>
	        /// 单行富文本信息
	        /// </summary>
	        [XmlElement("rich")]
	        public RichTextDomain Rich { get; set; }
	
	        /// <summary>
	        /// 消息体的标题，建议50个字符以内
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// OADomain Data Structure.
/// </summary>
[Serializable]

public class OADomain : TopObject
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
	        /// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接
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
/// FileDomain Data Structure.
/// </summary>
[Serializable]

public class FileDomain : TopObject
{
	        /// <summary>
	        /// 媒体文件id。引用的媒体文件最大10MB
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
	        /// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接
	        /// </summary>
	        [XmlElement("message_url")]
	        public string MessageUrl { get; set; }
	
	        /// <summary>
	        /// 图片地址
	        /// </summary>
	        [XmlElement("pic_url")]
	        public string PicUrl { get; set; }
	
	        /// <summary>
	        /// 消息描述，建议500字符以内
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
	
	        /// <summary>
	        /// 消息标题，建议100字符以内
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
	        /// markdown格式的消息，建议5000字符以内
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
/// ButtonDomain Data Structure.
/// </summary>
[Serializable]

public class ButtonDomain : TopObject
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
	        /// 使用独立跳转ActionCard样式时的按钮排列方式，竖直排列(0)，横向排列(1)；必须与button_list同时设置
	        /// </summary>
	        [XmlElement("btn_orientation")]
	        public string BtnOrientation { get; set; }
	
	        /// <summary>
	        /// 使用独立跳转ActionCard样式时的按钮列表；必须与btn_orientation同时设置
	        /// </summary>
	        [XmlArray("button_list")]
	        [XmlArrayItem("button")]
	        public List<ButtonDomain> ButtonList { get; set; }
	
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
/// MessageBodyDomain Data Structure.
/// </summary>
[Serializable]

public class MessageBodyDomain : TopObject
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
	        /// oa消息
	        /// </summary>
	        [XmlElement("oa")]
	        public OADomain Oa { get; set; }
	
	        /// <summary>
	        /// 语音消息
	        /// </summary>
	        [XmlElement("voice")]
	        public VoiceDomain Voice { get; set; }
}

        #endregion
    }
}
