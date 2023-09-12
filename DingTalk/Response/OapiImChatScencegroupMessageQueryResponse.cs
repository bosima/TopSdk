using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatScencegroupMessageQueryResponse.
    /// </summary>
    public class OapiImChatScencegroupMessageQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 统一错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [XmlElement("im_message")]
        public OpenGroupMessageDtoDomain ImMessage { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("succ")]
        public bool Succ { get; set; }

	/// <summary>
/// OpenGroupMessageAtUserDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenGroupMessageAtUserDtoDomain : TopObject
{
	        /// <summary>
	        /// unionId（如果没有userId则提供unionId)
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
	
	        /// <summary>
	        /// userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenGroupMessageDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenGroupMessageDtoDomain : TopObject
{
	        /// <summary>
	        /// 消息的at人信息
	        /// </summary>
	        [XmlArray("at_users")]
	        [XmlArrayItem("open_group_message_at_user_dto")]
	        public List<OpenGroupMessageAtUserDtoDomain> AtUsers { get; set; }
	
	        /// <summary>
	        /// 消息发送时间
	        /// </summary>
	        [XmlElement("create_at")]
	        public string CreateAt { get; set; }
	
	        /// <summary>
	        /// 消息内容密文
	        /// </summary>
	        [XmlElement("msg_content")]
	        public string MsgContent { get; set; }
}

    }
}
