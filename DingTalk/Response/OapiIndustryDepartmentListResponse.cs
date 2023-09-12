using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiIndustryDepartmentListResponse.
    /// </summary>
    public class OapiIndustryDepartmentListResponse : DingTalkResponse
    {
        /// <summary>
        /// 成功
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
        [XmlElement("result")]
        public ResultWrapperDomain Result { get; set; }

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
	        /// 传统农村类型
	        /// </summary>
	        [XmlElement("contact_type")]
	        public string ContactType { get; set; }
	
	        /// <summary>
	        /// 部门ID
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 户
	        /// </summary>
	        [XmlElement("dept_type")]
	        public string DeptType { get; set; }
	
	        /// <summary>
	        /// 部门属性信息
	        /// </summary>
	        [XmlElement("feature")]
	        public string Feature { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// ResultWrapperDomain Data Structure.
/// </summary>
[Serializable]

public class ResultWrapperDomain : TopObject
{
	        /// <summary>
	        /// details
	        /// </summary>
	        [XmlArray("details")]
	        [XmlArrayItem("open_industry_dept_info")]
	        public List<OpenIndustryDeptInfoDomain> Details { get; set; }
	
	        /// <summary>
	        /// 是否还有更多
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一个游标开始位置
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
