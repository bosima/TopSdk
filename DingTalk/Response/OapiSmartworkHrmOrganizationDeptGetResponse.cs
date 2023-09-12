using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmOrganizationDeptGetResponse.
    /// </summary>
    public class OapiSmartworkHrmOrganizationDeptGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果集
        /// </summary>
        [XmlElement("result")]
        public OrgDeptVODomain Result { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OrgDeptAttributeVoDomain Data Structure.
/// </summary>
[Serializable]

public class OrgDeptAttributeVoDomain : TopObject
{
	        /// <summary>
	        /// 字段code
	        /// </summary>
	        [XmlElement("field_code")]
	        public string FieldCode { get; set; }
	
	        /// <summary>
	        /// 字段value
	        /// </summary>
	        [XmlElement("field_value")]
	        public string FieldValue { get; set; }
}

	/// <summary>
/// OrgDeptVODomain Data Structure.
/// </summary>
[Serializable]

public class OrgDeptVODomain : TopObject
{
	        /// <summary>
	        /// 属性值列表
	        /// </summary>
	        [XmlArray("attribute_list")]
	        [XmlArrayItem("org_dept_attribute_vo")]
	        public List<OrgDeptAttributeVoDomain> AttributeList { get; set; }
	
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
}

    }
}
