using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiV2DepartmentCreateResponse.
    /// </summary>
    public class OapiV2DepartmentCreateResponse : DingTalkResponse
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
        /// 成功信息
        /// </summary>
        [XmlElement("result")]
        public DeptCreateResponseDomain Result { get; set; }

	/// <summary>
/// DeptCreateResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DeptCreateResponseDomain : TopObject
{
	        /// <summary>
	        /// 部门ID
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
}

    }
}
