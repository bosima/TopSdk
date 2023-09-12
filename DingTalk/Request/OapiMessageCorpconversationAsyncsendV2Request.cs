using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.message.corpconversation.asyncsend_v2
    /// </summary>
    public class OapiMessageCorpconversationAsyncsendV2Request : BaseDingTalkRequest<DingTalk.Api.Response.OapiMessageCorpconversationAsyncsendV2Response>
    {
        /// <summary>
        /// 微应用的id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 接收者的部门id列表
        /// </summary>
        public string DeptIdList { get; set; }

        /// <summary>
        /// 是否开启id转译，默认false。仅第三方应用需要用到，企业内部应用可以忽略
        /// </summary>
        public Nullable<bool> EnableIdTrans { get; set; }

        /// <summary>
        /// 消息体，具体见文档
        /// </summary>
        public string Msg { get; set; }

        public MsgDomain Msg_ { set { this.Msg = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 是否发送给企业全部用户
        /// </summary>
        public Nullable<bool> ToAllUser { get; set; }

        /// <summary>
        /// 接收者的用户userid列表
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.message.corpconversation.asyncsend_v2";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("dept_id_list", this.DeptIdList);
            parameters.Add("enable_id_trans", this.EnableIdTrans);
            parameters.Add("msg", this.Msg);
            parameters.Add("to_all_user", this.ToAllUser);
            parameters.Add("userid_list", this.UseridList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateMaxListSize("dept_id_list", this.DeptIdList, 500);
            RequestValidator.ValidateRequired("msg", this.Msg);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 5000);
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
/// ImageDomain Data Structure.
/// </summary>
[Serializable]

public class ImageDomain : TopObject
{
	        /// <summary>
	        /// 图片消息
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
	        /// 消息标题，建议100字符以内
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
	
	        /// <summary>
	        /// 消息描述，建议500字符以内
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
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
/// VoiceDomain Data Structure.
/// </summary>
[Serializable]

public class VoiceDomain : TopObject
{
	        /// <summary>
	        /// 正整数，小于60，表示音频时长
	        /// </summary>
	        [XmlElement("duration")]
	        public string Duration { get; set; }
	
	        /// <summary>
	        /// 媒体文件id。2MB，播放长度不超过60s，AMR格式
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
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
/// StatusBarDomain Data Structure.
/// </summary>
[Serializable]

public class StatusBarDomain : TopObject
{
	        /// <summary>
	        /// 状态栏背景色，默认为黑色
	        /// </summary>
	        [XmlElement("status_bg")]
	        public string StatusBg { get; set; }
	
	        /// <summary>
	        /// 状态栏文案
	        /// </summary>
	        [XmlElement("status_value")]
	        public string StatusValue { get; set; }
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
	
	        /// <summary>
	        /// 状态栏
	        /// </summary>
	        [XmlElement("status_bar")]
	        public StatusBarDomain StatusBar { get; set; }
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
/// BtnJsonListDomain Data Structure.
/// </summary>
[Serializable]

public class BtnJsonListDomain : TopObject
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
	        [XmlArrayItem("btn_json_list")]
	        public List<BtnJsonListDomain> BtnJsonList { get; set; }
	
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
	        /// OA消息
	        /// </summary>
	        [XmlElement("oa")]
	        public OADomain Oa { get; set; }
	
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
