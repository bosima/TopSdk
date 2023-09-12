using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasGroupmemberGetmemberlistResponse.
    /// </summary>
    public class OapiImpaasGroupmemberGetmemberlistResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlArray("member_list")]
        [XmlArrayItem("group_member_info")]
        public List<GroupMemberInfoDomain> MemberList { get; set; }

	/// <summary>
/// GroupMemberInfoDomain Data Structure.
/// </summary>
[Serializable]

public class GroupMemberInfoDomain : TopObject
{
	        /// <summary>
	        /// ext
	        /// </summary>
	        [XmlElement("ext")]
	        public string Ext { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// nick
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// role
	        /// </summary>
	        [XmlElement("role")]
	        public long Role { get; set; }
	
	        /// <summary>
	        /// type
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

    }
}
