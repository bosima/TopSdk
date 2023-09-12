using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRoleGetroleResponse.
    /// </summary>
    public class OapiRoleGetroleResponse : DingTalkResponse
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
        [XmlElement("role")]
        public OpenRoleDomain Role { get; set; }

	/// <summary>
/// OpenRoleDomain Data Structure.
/// </summary>
[Serializable]

public class OpenRoleDomain : TopObject
{
	        /// <summary>
	        /// 角色组id
	        /// </summary>
	        [XmlElement("groupId")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// 角色名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

    }
}
