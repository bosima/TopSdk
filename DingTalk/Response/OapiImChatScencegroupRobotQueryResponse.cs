using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatScencegroupRobotQueryResponse.
    /// </summary>
    public class OapiImChatScencegroupRobotQueryResponse : DingTalkResponse
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
        /// 机器人
        /// </summary>
        [XmlElement("robot")]
        public OpenRobotQueryResponseDomain Robot { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("succ")]
        public bool Succ { get; set; }

	/// <summary>
/// OpenRobotQueryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenRobotQueryResponseDomain : TopObject
{
	        /// <summary>
	        /// unionId（仅当userId无值时返回）
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
	
	        /// <summary>
	        /// userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
