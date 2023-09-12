using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpRoleSimplelistResponse.
    /// </summary>
    public class CorpRoleSimplelistResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public PageVoDomain Result { get; set; }

	/// <summary>
/// EmpSimpleListDomain Data Structure.
/// </summary>
[Serializable]

public class EmpSimpleListDomain : TopObject
{
	        /// <summary>
	        /// userId
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
	        /// hasMore
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("emp_simple_list")]
	        public List<EmpSimpleListDomain> List { get; set; }
}

    }
}
