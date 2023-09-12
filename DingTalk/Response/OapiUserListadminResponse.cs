using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserListadminResponse.
    /// </summary>
    public class OapiUserListadminResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码。0代表成功。
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("list_admin_response")]
        public List<ListAdminResponseDomain> Result { get; set; }

	/// <summary>
/// ListAdminResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ListAdminResponseDomain : TopObject
{
	        /// <summary>
	        /// 管理员角色，1 主管理员 2 子管理员
	        /// </summary>
	        [XmlElement("sys_level")]
	        public long SysLevel { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
