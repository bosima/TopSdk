using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiIndustryDepartmentGetResponse.
    /// </summary>
    public class OapiIndustryDepartmentGetResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlElement("result")]
        public OpenIndustryDeptInfoDomain Result { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenIndustryDeptInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenIndustryDeptInfoDomain : TopObject
{
	        /// <summary>
	        /// 通讯录类型，行业相关
	        /// </summary>
	        [XmlElement("contact_type")]
	        public string ContactType { get; set; }
	
	        /// <summary>
	        /// 部门类型，行业相关
	        /// </summary>
	        [XmlElement("dept_type")]
	        public string DeptType { get; set; }
	
	        /// <summary>
	        /// 部门属性
	        /// </summary>
	        [XmlElement("feature")]
	        public string Feature { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 父部门ID
	        /// </summary>
	        [XmlElement("super_id")]
	        public long SuperId { get; set; }
}

    }
}
