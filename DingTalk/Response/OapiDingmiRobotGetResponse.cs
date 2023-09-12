using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingmiRobotGetResponse.
    /// </summary>
    public class OapiDingmiRobotGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误MSG
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 机器人结果json
        /// </summary>
        [XmlElement("result")]
        public CustomCrowdRobotDTODomain Result { get; set; }

        /// <summary>
        /// 服务调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// CustomCrowdRobotDTODomain Data Structure.
/// </summary>
[Serializable]

public class CustomCrowdRobotDTODomain : TopObject
{
	        /// <summary>
	        /// 应用appid
	        /// </summary>
	        [XmlElement("app_id")]
	        public string AppId { get; set; }
	
	        /// <summary>
	        /// 描述
	        /// </summary>
	        [XmlElement("brief")]
	        public string Brief { get; set; }
	
	        /// <summary>
	        /// 机器人ID
	        /// </summary>
	        [XmlElement("chat_bolt_id")]
	        public string ChatBoltId { get; set; }
	
	        /// <summary>
	        /// 机器人描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 头像URL
	        /// </summary>
	        [XmlElement("icon_url")]
	        public string IconUrl { get; set; }
	
	        /// <summary>
	        /// 机器人名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 预览URL
	        /// </summary>
	        [XmlElement("preview_media_url")]
	        public string PreviewMediaUrl { get; set; }
}

    }
}
