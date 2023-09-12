using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiIndustryUserGetResponse.
    /// </summary>
    public class OapiIndustryUserGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 员工信息
        /// </summary>
        [XmlElement("result")]
        public OpenIndustryEmpDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenRoleDomain Data Structure.
/// </summary>
[Serializable]

public class OpenRoleDomain : TopObject
{
	        /// <summary>
	        /// 标签ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 标签名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// OpenIndustryEmpDomain Data Structure.
/// </summary>
[Serializable]

public class OpenIndustryEmpDomain : TopObject
{
	        /// <summary>
	        /// 员工特征
	        /// </summary>
	        [XmlElement("feature")]
	        public string Feature { get; set; }
	
	        /// <summary>
	        /// 员工名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 员工角色列表
	        /// </summary>
	        [XmlArray("roles")]
	        [XmlArrayItem("open_role")]
	        public List<OpenRoleDomain> Roles { get; set; }
	
	        /// <summary>
	        /// unionId
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
}

    }
}
