using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiV2DepartmentListparentbyuserResponse.
    /// </summary>
    public class OapiV2DepartmentListparentbyuserResponse : DingTalkResponse
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
        /// 成功数据信息
        /// </summary>
        [XmlElement("result")]
        public DeptListParentByUserResponseDomain Result { get; set; }

	/// <summary>
/// DeptParentResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DeptParentResponseDomain : TopObject
{
	        /// <summary>
	        /// 父部门列表
	        /// </summary>
	        [XmlArray("parent_dept_id_list")]
	        [XmlArrayItem("number")]
	        public List<long> ParentDeptIdList { get; set; }
}

	/// <summary>
/// DeptListParentByUserResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DeptListParentByUserResponseDomain : TopObject
{
	        /// <summary>
	        /// 父部门列表集合
	        /// </summary>
	        [XmlArray("parent_list")]
	        [XmlArrayItem("dept_parent_response")]
	        public List<DeptParentResponseDomain> ParentList { get; set; }
}

    }
}
