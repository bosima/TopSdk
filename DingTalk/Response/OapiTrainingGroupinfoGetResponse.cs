using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiTrainingGroupinfoGetResponse.
    /// </summary>
    public class OapiTrainingGroupinfoGetResponse : DingTalkResponse
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
        /// 返回群信息
        /// </summary>
        [XmlElement("result")]
        public GroupInfoDomain Result { get; set; }

	/// <summary>
/// GroupInfoDomain Data Structure.
/// </summary>
[Serializable]

public class GroupInfoDomain : TopObject
{
	        /// <summary>
	        /// 群id
	        /// </summary>
	        [XmlElement("conversation_id")]
	        public string ConversationId { get; set; }
	
	        /// <summary>
	        /// 群创建时间
	        /// </summary>
	        [XmlElement("create_at")]
	        public long CreateAt { get; set; }
	
	        /// <summary>
	        /// 群头像
	        /// </summary>
	        [XmlElement("icon_url")]
	        public string IconUrl { get; set; }
	
	        /// <summary>
	        /// 邀请链接
	        /// </summary>
	        [XmlElement("invite_url")]
	        public string InviteUrl { get; set; }
	
	        /// <summary>
	        /// 群成员数
	        /// </summary>
	        [XmlElement("member_count")]
	        public long MemberCount { get; set; }
	
	        /// <summary>
	        /// 群状态：1、available（可用），2、dismiss(解散），3、full（已满）
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 群名称
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
