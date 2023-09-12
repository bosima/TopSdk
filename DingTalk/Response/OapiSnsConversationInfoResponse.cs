using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSnsConversationInfoResponse.
    /// </summary>
    public class OapiSnsConversationInfoResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果数据
        /// </summary>
        [XmlElement("result")]
        public SnsOpenGroupInfoResponseDomain Result { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// SnsOpenGroupInfoResponseDomain Data Structure.
/// </summary>
[Serializable]

public class SnsOpenGroupInfoResponseDomain : TopObject
{
	        /// <summary>
	        /// 群头像
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 会话ID
	        /// </summary>
	        [XmlElement("open_conversation_id")]
	        public string OpenConversationId { get; set; }
	
	        /// <summary>
	        /// 群主id
	        /// </summary>
	        [XmlElement("owner_unionid")]
	        public string OwnerUnionid { get; set; }
	
	        /// <summary>
	        /// 机器人发消息地址
	        /// </summary>
	        [XmlElement("robot_web_hook_url")]
	        public string RobotWebHookUrl { get; set; }
	
	        /// <summary>
	        /// 模板id
	        /// </summary>
	        [XmlElement("template_id")]
	        public string TemplateId { get; set; }
	
	        /// <summary>
	        /// 群名称
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
