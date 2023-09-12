using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRoleSimplelistResponse.
    /// </summary>
    public class OapiRoleSimplelistResponse : DingTalkResponse
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
/// OrgDeptVoDomain Data Structure.
/// </summary>
[Serializable]

public class OrgDeptVoDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// OpenEmpSimpleDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEmpSimpleDomain : TopObject
{
	        /// <summary>
	        /// 管理范围
	        /// </summary>
	        [XmlArray("manageScopes")]
	        [XmlArrayItem("org_dept_vo")]
	        public List<OrgDeptVoDomain> ManageScopes { get; set; }
	
	        /// <summary>
	        /// 员工姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// PageVoDomain Data Structure.
/// </summary>
[Serializable]

public class PageVoDomain : TopObject
{
	        /// <summary>
	        /// 后面是否还有数据
	        /// </summary>
	        [XmlElement("hasMore")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("open_emp_simple")]
	        public List<OpenEmpSimpleDomain> List { get; set; }
	
	        /// <summary>
	        /// 下次拉取数据的游标
	        /// </summary>
	        [XmlElement("nextCursor")]
	        public long NextCursor { get; set; }
}

    }
}
