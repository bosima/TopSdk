using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiOrgUnionTrunkGetResponse.
    /// </summary>
    public class OapiOrgUnionTrunkGetResponse : DingTalkResponse
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
	        /// 主干组织的corpid
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 主干组织的名称
	        /// </summary>
	        [XmlElement("org_name")]
	        public string OrgName { get; set; }
}

    }
}
