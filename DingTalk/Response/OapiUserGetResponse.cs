using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserGetResponse.
    /// </summary>
    public class OapiUserGetResponse : DingTalkResponse
    {
        /// <summary>
        /// active
        /// </summary>
        [XmlElement("active")]
        public bool Active { get; set; }

        /// <summary>
        /// associatedUnionId
        /// </summary>
        [XmlElement("associatedUnionId")]
        public string AssociatedUnionId { get; set; }

        /// <summary>
        /// avatar
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// department
        /// </summary>
        [XmlArray("department")]
        [XmlArrayItem("number")]
        public List<long> Department { get; set; }

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
        /// inviteMobile
        /// </summary>
        [XmlElement("inviteMobile")]
        public string InviteMobile { get; set; }

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
        /// isCustomizedPortal
        /// </summary>
        [XmlElement("isCustomizedPortal")]
        public bool IsCustomizedPortal { get; set; }

        /// <summary>
        /// isHide
        /// </summary>
        [XmlElement("isHide")]
        public bool IsHide { get; set; }

        /// <summary>
        /// isLeaderInDepts
        /// </summary>
        [XmlElement("isLeaderInDepts")]
        public string IsLeaderInDepts { get; set; }

        /// <summary>
        /// isLimited
        /// </summary>
        [XmlElement("isLimited")]
        public bool IsLimited { get; set; }

        /// <summary>
        /// isSenior
        /// </summary>
        [XmlElement("isSenior")]
        public bool IsSenior { get; set; }

        /// <summary>
        /// jobnumber
        /// </summary>
        [XmlElement("jobnumber")]
        public string Jobnumber { get; set; }

        /// <summary>
        /// mana
        /// </summary>
        [XmlElement("managerUserId")]
        public string ManagerUserId { get; set; }

        /// <summary>
        /// memberView
        /// </summary>
        [XmlElement("memberView")]
        public bool MemberView { get; set; }

        /// <summary>
        /// mobile
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// mobileHash
        /// </summary>
        [XmlElement("mobileHash")]
        public string MobileHash { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// nickname
        /// </summary>
        [XmlElement("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// openId
        /// </summary>
        [XmlElement("openId")]
        public string OpenId { get; set; }

        /// <summary>
        /// orderInDepts
        /// </summary>
        [XmlElement("orderInDepts")]
        public string OrderInDepts { get; set; }

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
        /// realAuthed
        /// </summary>
        [XmlElement("realAuthed")]
        public bool RealAuthed { get; set; }

        /// <summary>
        /// remark
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// roles
        /// </summary>
        [XmlArray("roles")]
        [XmlArrayItem("roles")]
        public List<RolesDomain> Roles { get; set; }

        /// <summary>
        /// stateCode
        /// </summary>
        [XmlElement("stateCode")]
        public string StateCode { get; set; }

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

	/// <summary>
/// RolesDomain Data Structure.
/// </summary>
[Serializable]

public class RolesDomain : TopObject
{
	        /// <summary>
	        /// groupName
	        /// </summary>
	        [XmlElement("groupName")]
	        public string GroupName { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// name
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// type
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
}

    }
}
