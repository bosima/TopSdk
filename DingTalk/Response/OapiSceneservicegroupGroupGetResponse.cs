using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSceneservicegroupGroupGetResponse.
    /// </summary>
    public class OapiSceneservicegroupGroupGetResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("result")]
        public GetGroupResponseDomain Result { get; set; }

	/// <summary>
/// GetGroupResponseDomain Data Structure.
/// </summary>
[Serializable]

public class GetGroupResponseDomain : TopObject
{
	        /// <summary>
	        /// 群名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
	
	        /// <summary>
	        /// 入群二维码
	        /// </summary>
	        [XmlElement("group_url")]
	        public string GroupUrl { get; set; }
	
	        /// <summary>
	        /// 开放群ID
	        /// </summary>
	        [XmlElement("open_conversationid")]
	        public string OpenConversationid { get; set; }
	
	        /// <summary>
	        /// 开放服务群群组id
	        /// </summary>
	        [XmlElement("open_groupsetid")]
	        public string OpenGroupsetid { get; set; }
	
	        /// <summary>
	        /// 开放服务群团队id
	        /// </summary>
	        [XmlElement("open_teamid")]
	        public string OpenTeamid { get; set; }
	
	        /// <summary>
	        /// 服务群机器人Code
	        /// </summary>
	        [XmlElement("robot_code")]
	        public string RobotCode { get; set; }
	
	        /// <summary>
	        /// 服务群机器人名称
	        /// </summary>
	        [XmlElement("robot_name")]
	        public string RobotName { get; set; }
}

    }
}
