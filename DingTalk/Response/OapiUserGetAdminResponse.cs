using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserGetAdminResponse.
    /// </summary>
    public class OapiUserGetAdminResponse : DingTalkResponse
    {
        /// <summary>
        /// admin_list
        /// </summary>
        [XmlArray("admin_list")]
        [XmlArrayItem("admin_list")]
        public List<AdminListDomain> AdminList { get; set; }

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
/// AdminListDomain Data Structure.
/// </summary>
[Serializable]

public class AdminListDomain : TopObject
{
	        /// <summary>
	        /// admin_mobile
	        /// </summary>
	        [XmlElement("admin_mobile")]
	        public string AdminMobile { get; set; }
	
	        /// <summary>
	        /// sys_level
	        /// </summary>
	        [XmlElement("sys_level")]
	        public long SysLevel { get; set; }
	
	        /// <summary>
	        /// userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
