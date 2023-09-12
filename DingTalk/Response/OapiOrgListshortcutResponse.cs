using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiOrgListshortcutResponse.
    /// </summary>
    public class OapiOrgListshortcutResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// OrgShortcutVODomain Data Structure.
/// </summary>
[Serializable]

public class OrgShortcutVODomain : TopObject
{
	        /// <summary>
	        /// 类型，1表示工作台微应用
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
	
	        /// <summary>
	        /// 微应用的agentId
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
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
	        [XmlElement("errcode")]
	        public long Errcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("errmsg")]
	        public string Errmsg { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlArray("shortcuts")]
	        [XmlArrayItem("org_shortcut_v_o")]
	        public List<OrgShortcutVODomain> Shortcuts { get; set; }
}

    }
}
