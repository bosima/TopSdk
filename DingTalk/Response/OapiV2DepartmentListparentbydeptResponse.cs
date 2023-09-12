using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiV2DepartmentListparentbydeptResponse.
    /// </summary>
    public class OapiV2DepartmentListparentbydeptResponse : DingTalkResponse
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
        /// 父部门ID列表
        /// </summary>
        [XmlElement("result")]
        public DeptListParentByDeptIdResponseDomain Result { get; set; }

	/// <summary>
/// DeptListParentByDeptIdResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DeptListParentByDeptIdResponseDomain : TopObject
{
	        /// <summary>
	        /// 该部门的所有父部门id列表
	        /// </summary>
	        [XmlArray("parent_id_list")]
	        [XmlArrayItem("number")]
	        public List<long> ParentIdList { get; set; }
}

    }
}
