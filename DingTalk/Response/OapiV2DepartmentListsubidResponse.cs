using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiV2DepartmentListsubidResponse.
    /// </summary>
    public class OapiV2DepartmentListsubidResponse : DingTalkResponse
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
        /// 子部门信息
        /// </summary>
        [XmlElement("result")]
        public DeptListSubIdResponseDomain Result { get; set; }

	/// <summary>
/// DeptListSubIdResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DeptListSubIdResponseDomain : TopObject
{
	        /// <summary>
	        /// 子部门列表
	        /// </summary>
	        [XmlArray("dept_id_list")]
	        [XmlArrayItem("number")]
	        public List<long> DeptIdList { get; set; }
}

    }
}
