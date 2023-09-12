using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduDeptGetResponse.
    /// </summary>
    public class OapiEduDeptGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码，只有在success为false时才有效
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息，只有在success为false时才有效
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果集
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenEduDeptDetailDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduDeptDetailDomain : TopObject
{
	        /// <summary>
	        /// 部门链，不包括当前部门
	        /// </summary>
	        [XmlElement("chain")]
	        public string Chain { get; set; }
	
	        /// <summary>
	        /// 通讯录类型。自定义or经典模型
	        /// </summary>
	        [XmlElement("contact_type")]
	        public string ContactType { get; set; }
	
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 部门节点类型
	        /// </summary>
	        [XmlElement("dept_type")]
	        public string DeptType { get; set; }
	
	        /// <summary>
	        /// 部门节点特有属性
	        /// </summary>
	        [XmlElement("feature")]
	        public string Feature { get; set; }
	
	        /// <summary>
	        /// 部门名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 部门nick
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 部门详情
	        /// </summary>
	        [XmlElement("detail")]
	        public OpenEduDeptDetailDomain Detail { get; set; }
}

    }
}
