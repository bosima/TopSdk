using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiContactRolevisibilityGetResponse.
    /// </summary>
    public class OapiContactRolevisibilityGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 权限设置列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("open_role_permission_for_contact")]
        public List<OpenRolePermissionForContactDomain> Result { get; set; }

        /// <summary>
        /// 是否成功: true表示成功，false表示失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenRolePermissionForContactDomain Data Structure.
/// </summary>
[Serializable]

public class OpenRolePermissionForContactDomain : TopObject
{
	        /// <summary>
	        /// 部门id列表
	        /// </summary>
	        [XmlArray("dept_ids")]
	        [XmlArrayItem("number")]
	        public List<long> DeptIds { get; set; }
	
	        /// <summary>
	        /// 角色id列表
	        /// </summary>
	        [XmlArray("role_ids")]
	        [XmlArrayItem("number")]
	        public List<long> RoleIds { get; set; }
	
	        /// <summary>
	        /// SubjectSide(1) 还是 ObjectSide(2)
	        /// </summary>
	        [XmlElement("side")]
	        public long Side { get; set; }
	
	        /// <summary>
	        /// permit(1) 还是 deny(2)
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
	
	        /// <summary>
	        /// staffid列表
	        /// </summary>
	        [XmlArray("user_ids")]
	        [XmlArrayItem("string")]
	        public List<string> UserIds { get; set; }
	
	        /// <summary>
	        /// 可见性设置类型：5. permit_self_node_and_children(仅可见自己所在节点及子节点)    6. permit_self_node_only(仅可见自己所在的节点)    7. permit_self_only(仅可见自己)
	        /// </summary>
	        [XmlElement("visibility_type")]
	        public long VisibilityType { get; set; }
}

    }
}
