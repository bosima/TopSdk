using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiOrgUnionBranchGetResponse.
    /// </summary>
    public class OapiOrgUnionBranchGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误code
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误msg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// OpenOrgUnion
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("open_org_union")]
        public List<OpenOrgUnionDomain> Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenOrgUnionDomain Data Structure.
/// </summary>
[Serializable]

public class OpenOrgUnionDomain : TopObject
{
	        /// <summary>
	        /// 分支组织corpid
	        /// </summary>
	        [XmlElement("union_corpid")]
	        public string UnionCorpid { get; set; }
	
	        /// <summary>
	        /// 分支组织名称
	        /// </summary>
	        [XmlElement("union_org_name")]
	        public string UnionOrgName { get; set; }
}

    }
}
