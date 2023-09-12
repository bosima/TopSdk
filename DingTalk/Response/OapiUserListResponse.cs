using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserListResponse.
    /// </summary>
    public class OapiUserListResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// hasMore
        /// </summary>
        [XmlElement("hasMore")]
        public bool HasMore { get; set; }

        /// <summary>
        /// userlist
        /// </summary>
        [XmlArray("userlist")]
        [XmlArrayItem("userlist")]
        public List<UserlistDomain> Userlist { get; set; }

	/// <summary>
/// UserlistDomain Data Structure.
/// </summary>
[Serializable]

public class UserlistDomain : TopObject
{
	        /// <summary>
	        /// active
	        /// </summary>
	        [XmlElement("active")]
	        public bool Active { get; set; }
	
	        /// <summary>
	        /// avatar
	        /// </summary>
	        [XmlElement("avatar")]
	        public string Avatar { get; set; }
	
	        /// <summary>
	        /// department
	        /// </summary>
	        [XmlElement("department")]
	        public string Department { get; set; }
	
	        /// <summary>
	        /// dingId
	        /// </summary>
	        [XmlElement("dingId")]
	        public string DingId { get; set; }
	
	        /// <summary>
	        /// email
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// extattr
	        /// </summary>
	        [XmlElement("extattr")]
	        public string Extattr { get; set; }
	
	        /// <summary>
	        /// hiredDate
	        /// </summary>
	        [XmlElement("hiredDate")]
	        public string HiredDate { get; set; }
	
	        /// <summary>
	        /// isAdmin
	        /// </summary>
	        [XmlElement("isAdmin")]
	        public bool IsAdmin { get; set; }
	
	        /// <summary>
	        /// isBoss
	        /// </summary>
	        [XmlElement("isBoss")]
	        public bool IsBoss { get; set; }
	
	        /// <summary>
	        /// isHide
	        /// </summary>
	        [XmlElement("isHide")]
	        public bool IsHide { get; set; }
	
	        /// <summary>
	        /// isLeader
	        /// </summary>
	        [XmlElement("isLeader")]
	        public bool IsLeader { get; set; }
	
	        /// <summary>
	        /// jobnumber
	        /// </summary>
	        [XmlElement("jobnumber")]
	        public string Jobnumber { get; set; }
	
	        /// <summary>
	        /// mobile
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// name
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// order
	        /// </summary>
	        [XmlElement("order")]
	        public long Order { get; set; }
	
	        /// <summary>
	        /// orgEmail
	        /// </summary>
	        [XmlElement("orgEmail")]
	        public string OrgEmail { get; set; }
	
	        /// <summary>
	        /// position
	        /// </summary>
	        [XmlElement("position")]
	        public string Position { get; set; }
	
	        /// <summary>
	        /// remark
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// tel
	        /// </summary>
	        [XmlElement("tel")]
	        public string Tel { get; set; }
	
	        /// <summary>
	        /// unionid
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
	
	        /// <summary>
	        /// userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// workPlace
	        /// </summary>
	        [XmlElement("workPlace")]
	        public string WorkPlace { get; set; }
}

    }
}
