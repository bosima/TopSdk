using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiHireAuthRoleGetbyuserResponse.
    /// </summary>
    public class OapiHireAuthRoleGetbyuserResponse : DingTalkResponse
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
        /// 角色列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("hire_role_simple_vo")]
        public List<HireRoleSimpleVoDomain> Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// HireRoleSimpleVoDomain Data Structure.
/// </summary>
[Serializable]

public class HireRoleSimpleVoDomain : TopObject
{
	        /// <summary>
	        /// 角色名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 角色类型：1表示管理员，2表示HR，3表示面试官，4表示用人经理
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
}

    }
}
