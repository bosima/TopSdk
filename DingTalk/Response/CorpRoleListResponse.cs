using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpRoleListResponse.
    /// </summary>
    public class CorpRoleListResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

	/// <summary>
/// RolesDomain Data Structure.
/// </summary>
[Serializable]

public class RolesDomain : TopObject
{
	        /// <summary>
	        /// 角色ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 角色名称
	        /// </summary>
	        [XmlElement("role_name")]
	        public string RoleName { get; set; }
}

	/// <summary>
/// RoleGroupsDomain Data Structure.
/// </summary>
[Serializable]

public class RoleGroupsDomain : TopObject
{
	        /// <summary>
	        /// 角色分组名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
	
	        /// <summary>
	        /// 角色列表
	        /// </summary>
	        [XmlArray("roles")]
	        [XmlArrayItem("roles")]
	        public List<RolesDomain> Roles { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 分页是否还有数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public string HasMore { get; set; }
	
	        /// <summary>
	        /// 角色分组列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("role_groups")]
	        public List<RoleGroupsDomain> List { get; set; }
}

    }
}
