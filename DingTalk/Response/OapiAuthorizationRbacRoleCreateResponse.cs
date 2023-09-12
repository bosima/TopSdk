using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAuthorizationRbacRoleCreateResponse.
    /// </summary>
    public class OapiAuthorizationRbacRoleCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// errcode
	        /// </summary>
	        [XmlElement("errcode")]
	        public long Errcode { get; set; }
	
	        /// <summary>
	        /// erromsg
	        /// </summary>
	        [XmlElement("errmsg")]
	        public string Errmsg { get; set; }
	
	        /// <summary>
	        /// 管理组id
	        /// </summary>
	        [XmlElement("result")]
	        public string Result { get; set; }
	
	        /// <summary>
	        /// 请求状态
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
