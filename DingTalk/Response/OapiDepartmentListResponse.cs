using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDepartmentListResponse.
    /// </summary>
    public class OapiDepartmentListResponse : DingTalkResponse
    {
        /// <summary>
        /// department
        /// </summary>
        [XmlArray("department")]
        [XmlArrayItem("department")]
        public List<DepartmentDomain> Department { get; set; }

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
/// DepartmentDomain Data Structure.
/// </summary>
[Serializable]

public class DepartmentDomain : TopObject
{
	        /// <summary>
	        /// autoAddUser
	        /// </summary>
	        [XmlElement("autoAddUser")]
	        public bool AutoAddUser { get; set; }
	
	        /// <summary>
	        /// createDeptGroup
	        /// </summary>
	        [XmlElement("createDeptGroup")]
	        public bool CreateDeptGroup { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// isFromUnionOrg
	        /// </summary>
	        [XmlElement("isFromUnionOrg")]
	        public bool IsFromUnionOrg { get; set; }
	
	        /// <summary>
	        /// name
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// parentid
	        /// </summary>
	        [XmlElement("parentid")]
	        public long Parentid { get; set; }
	
	        /// <summary>
	        /// sourceIdentifier
	        /// </summary>
	        [XmlElement("sourceIdentifier")]
	        public string SourceIdentifier { get; set; }
}

    }
}
