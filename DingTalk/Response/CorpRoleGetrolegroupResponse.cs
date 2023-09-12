using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpRoleGetrolegroupResponse.
    /// </summary>
    public class CorpRoleGetrolegroupResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// OpenRoleDomain Data Structure.
/// </summary>
[Serializable]

public class OpenRoleDomain : TopObject
{
	        /// <summary>
	        /// 角色id
	        /// </summary>
	        [XmlElement("role_id")]
	        public long RoleId { get; set; }
	
	        /// <summary>
	        /// 角色名
	        /// </summary>
	        [XmlElement("role_name")]
	        public string RoleName { get; set; }
}

	/// <summary>
/// OpenRoleGroupDomain Data Structure.
/// </summary>
[Serializable]

public class OpenRoleGroupDomain : TopObject
{
	        /// <summary>
	        /// 角色组名
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
	
	        /// <summary>
	        /// 角色列表信息
	        /// </summary>
	        [XmlArray("roles")]
	        [XmlArrayItem("open_role")]
	        public List<OpenRoleDomain> Roles { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 角色组信息
	        /// </summary>
	        [XmlElement("role_group")]
	        public OpenRoleGroupDomain RoleGroup { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
