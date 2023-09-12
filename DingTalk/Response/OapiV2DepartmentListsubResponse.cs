using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiV2DepartmentListsubResponse.
    /// </summary>
    public class OapiV2DepartmentListsubResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 部门列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("dept_base_response")]
        public List<DeptBaseResponseDomain> Result { get; set; }

	/// <summary>
/// DeptBaseResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DeptBaseResponseDomain : TopObject
{
	        /// <summary>
	        /// 当群已经创建后，是否有新人加入部门会自动加入该群
	        /// </summary>
	        [XmlElement("auto_add_user")]
	        public bool AutoAddUser { get; set; }
	
	        /// <summary>
	        /// 是否同步创建一个关联此部门的企业群
	        /// </summary>
	        [XmlElement("create_dept_group")]
	        public bool CreateDeptGroup { get; set; }
	
	        /// <summary>
	        /// 部门ID
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 扩展字段
	        /// </summary>
	        [XmlElement("ext")]
	        public string Ext { get; set; }
	
	        /// <summary>
	        /// 部门是否来自关联组织
	        /// </summary>
	        [XmlElement("from_union_org")]
	        public bool FromUnionOrg { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 父部门ID
	        /// </summary>
	        [XmlElement("parent_id")]
	        public long ParentId { get; set; }
	
	        /// <summary>
	        /// 部门标识字段
	        /// </summary>
	        [XmlElement("source_identifier")]
	        public string SourceIdentifier { get; set; }
	
	        /// <summary>
	        /// 教育行业部门类型
	        /// </summary>
	        [XmlElement("tags")]
	        public string Tags { get; set; }
}

    }
}
