using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatScenegroupMemberGetResponse.
    /// </summary>
    public class OapiImChatScenegroupMemberGetResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public OpenSceneGroupMemberQueryResponseDomain Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenSceneGroupMemberQueryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenSceneGroupMemberQueryResponseDomain : TopObject
{
	        /// <summary>
	        /// 是否还有剩余成员
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 作为客户联系人的staffId
	        /// </summary>
	        [XmlArray("member_contact_staff_ids")]
	        [XmlArrayItem("string")]
	        public List<string> MemberContactStaffIds { get; set; }
	
	        /// <summary>
	        /// 群成员的userid
	        /// </summary>
	        [XmlArray("member_user_ids")]
	        [XmlArrayItem("string")]
	        public List<string> MemberUserIds { get; set; }
	
	        /// <summary>
	        /// 下一次请求的游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public string NextCursor { get; set; }
	
	        /// <summary>
	        /// staffId昵称映射
	        /// </summary>
	        [XmlElement("staff_id_nick_map")]
	        public string StaffIdNickMap { get; set; }
	
	        /// <summary>
	        /// unionId昵称映射
	        /// </summary>
	        [XmlElement("union_id_nick_map")]
	        public string UnionIdNickMap { get; set; }
	
	        /// <summary>
	        /// 外部客户的unionId
	        /// </summary>
	        [XmlArray("union_ids")]
	        [XmlArrayItem("string")]
	        public List<string> UnionIds { get; set; }
}

    }
}
