using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRoleListResponse.
    /// </summary>
    public class OapiRoleListResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlElement("result")]
        public PageVoDomain Result { get; set; }

	/// <summary>
/// OpenRoleDomain Data Structure.
/// </summary>
[Serializable]

public class OpenRoleDomain : TopObject
{
	        /// <summary>
	        /// 角色id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 角色名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// OpenRoleGroupDomain Data Structure.
/// </summary>
[Serializable]

public class OpenRoleGroupDomain : TopObject
{
	        /// <summary>
	        /// 角色组id
	        /// </summary>
	        [XmlElement("groupId")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// 角色组名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// roles
	        /// </summary>
	        [XmlArray("roles")]
	        [XmlArrayItem("open_role")]
	        public List<OpenRoleDomain> Roles { get; set; }
}

	/// <summary>
/// PageVoDomain Data Structure.
/// </summary>
[Serializable]

public class PageVoDomain : TopObject
{
	        /// <summary>
	        /// hasMore
	        /// </summary>
	        [XmlElement("hasMore")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("open_role_group")]
	        public List<OpenRoleGroupDomain> List { get; set; }
	
	        /// <summary>
	        /// 下次拉取数据的游标
	        /// </summary>
	        [XmlElement("nextCursor")]
	        public long NextCursor { get; set; }
}

    }
}
