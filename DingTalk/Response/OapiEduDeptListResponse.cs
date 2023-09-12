using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduDeptListResponse.
    /// </summary>
    public class OapiEduDeptListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码，只有success为false时有效
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息，只有success为false有效
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 数据集，不为空。
        /// </summary>
        [XmlElement("result")]
        public OpenEduDeptListResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenEduDeptDetailsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduDeptDetailsDomain : TopObject
{
	        /// <summary>
	        /// 部门链
	        /// </summary>
	        [XmlElement("chain")]
	        public string Chain { get; set; }
	
	        /// <summary>
	        /// 家校通讯录类型。自定义or标准
	        /// </summary>
	        [XmlElement("contact_type")]
	        public string ContactType { get; set; }
	
	        /// <summary>
	        /// 节点id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 节点类型
	        /// </summary>
	        [XmlElement("dept_type")]
	        public string DeptType { get; set; }
	
	        /// <summary>
	        /// 节点特有属性
	        /// </summary>
	        [XmlElement("feature")]
	        public string Feature { get; set; }
	
	        /// <summary>
	        /// 节点名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 可空
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
}

	/// <summary>
/// OpenEduDeptListResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduDeptListResponseDomain : TopObject
{
	        /// <summary>
	        /// 部门节点列表，不空。
	        /// </summary>
	        [XmlArray("details")]
	        [XmlArrayItem("open_edu_dept_details")]
	        public List<OpenEduDeptDetailsDomain> Details { get; set; }
	
	        /// <summary>
	        /// 是否有更多数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 父部门id
	        /// </summary>
	        [XmlElement("super_id")]
	        public long SuperId { get; set; }
}

    }
}
