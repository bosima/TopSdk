using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAuthScopesResponse.
    /// </summary>
    public class OapiAuthScopesResponse : DingTalkResponse
    {
        /// <summary>
        /// auth_org_scopes
        /// </summary>
        [XmlElement("auth_org_scopes")]
        public AuthOrgScopesDomain AuthOrgScopes { get; set; }

        /// <summary>
        /// 可以得到的企业用户字段
        /// </summary>
        [XmlArray("auth_user_field")]
        [XmlArrayItem("string")]
        public List<string> AuthUserField { get; set; }

        /// <summary>
        /// ISV可以直接使用企业的功能字段
        /// </summary>
        [XmlArray("condition_field")]
        [XmlArrayItem("string")]
        public List<string> ConditionField { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 对返回码的文本描述内容
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

	/// <summary>
/// AuthOrgScopesDomain Data Structure.
/// </summary>
[Serializable]

public class AuthOrgScopesDomain : TopObject
{
	        /// <summary>
	        /// 企业授权的部门id列表
	        /// </summary>
	        [XmlArray("authed_dept")]
	        [XmlArrayItem("number")]
	        public List<long> AuthedDept { get; set; }
	
	        /// <summary>
	        /// 企业授权的员工userid列表
	        /// </summary>
	        [XmlArray("authed_user")]
	        [XmlArrayItem("string")]
	        public List<string> AuthedUser { get; set; }
}

    }
}
