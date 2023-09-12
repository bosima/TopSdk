using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCspaceAuditlogListResponse.
    /// </summary>
    public class OapiCspaceAuditlogListResponse : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ListAuditLogResultDomain Result { get; set; }

        /// <summary>
        /// 请求结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// DocMemberInfoVoDomain Data Structure.
/// </summary>
[Serializable]

public class DocMemberInfoVoDomain : TopObject
{
	        /// <summary>
	        /// 成员名称
	        /// </summary>
	        [XmlElement("member_name")]
	        public string MemberName { get; set; }
	
	        /// <summary>
	        /// 成员类型
	        /// </summary>
	        [XmlElement("member_type")]
	        public long MemberType { get; set; }
	
	        /// <summary>
	        /// 成员类型翻译值
	        /// </summary>
	        [XmlElement("member_type_view")]
	        public string MemberTypeView { get; set; }
	
	        /// <summary>
	        /// 权限角色
	        /// </summary>
	        [XmlElement("permission_role")]
	        public long PermissionRole { get; set; }
	
	        /// <summary>
	        /// 权限角色预览
	        /// </summary>
	        [XmlElement("permission_role_view")]
	        public string PermissionRoleView { get; set; }
}

	/// <summary>
/// DocReceiverVoDomain Data Structure.
/// </summary>
[Serializable]

public class DocReceiverVoDomain : TopObject
{
	        /// <summary>
	        /// 成员名称
	        /// </summary>
	        [XmlElement("receiver_name")]
	        public string ReceiverName { get; set; }
	
	        /// <summary>
	        /// 成员类型
	        /// </summary>
	        [XmlElement("receiver_type")]
	        public long ReceiverType { get; set; }
	
	        /// <summary>
	        /// 成员类型翻译值
	        /// </summary>
	        [XmlElement("receiver_type_view")]
	        public string ReceiverTypeView { get; set; }
}

	/// <summary>
/// AuditLogVODomain Data Structure.
/// </summary>
[Serializable]

public class AuditLogVODomain : TopObject
{
	        /// <summary>
	        /// 操作类型
	        /// </summary>
	        [XmlElement("action")]
	        public long Action { get; set; }
	
	        /// <summary>
	        /// 操作类型翻译值
	        /// </summary>
	        [XmlElement("action_view")]
	        public string ActionView { get; set; }
	
	        /// <summary>
	        /// 文件id
	        /// </summary>
	        [XmlElement("biz_id")]
	        public string BizId { get; set; }
	
	        /// <summary>
	        /// 文档授权成员列表，仅授权文档操作有效
	        /// </summary>
	        [XmlArray("doc_member_info_list")]
	        [XmlArrayItem("doc_member_info_vo")]
	        public List<DocMemberInfoVoDomain> DocMemberInfoList { get; set; }
	
	        /// <summary>
	        /// 文档分享成员列表，仅分享文档时有效
	        /// </summary>
	        [XmlArray("doc_receiver_list")]
	        [XmlArrayItem("doc_receiver_vo")]
	        public List<DocReceiverVoDomain> DocReceiverList { get; set; }
	
	        /// <summary>
	        /// 记录生成时间，unix时间戳，单位ms
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public long GmtCreate { get; set; }
	
	        /// <summary>
	        /// 记录修改时间，unix时间戳，单位ms
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public long GmtModified { get; set; }
	
	        /// <summary>
	        /// 操作机器ip
	        /// </summary>
	        [XmlElement("ip_address")]
	        public string IpAddress { get; set; }
	
	        /// <summary>
	        /// 操作来源空间
	        /// </summary>
	        [XmlElement("operate_module")]
	        public long OperateModule { get; set; }
	
	        /// <summary>
	        /// 操作来源翻译值
	        /// </summary>
	        [XmlElement("operate_module_view")]
	        public string OperateModuleView { get; set; }
	
	        /// <summary>
	        /// 用户昵称
	        /// </summary>
	        [XmlElement("operator_name")]
	        public string OperatorName { get; set; }
	
	        /// <summary>
	        /// 文件所属组织名称
	        /// </summary>
	        [XmlElement("org_name")]
	        public string OrgName { get; set; }
	
	        /// <summary>
	        /// 操作端
	        /// </summary>
	        [XmlElement("platform")]
	        public long Platform { get; set; }
	
	        /// <summary>
	        /// 操作端翻译值
	        /// </summary>
	        [XmlElement("platform_view")]
	        public string PlatformView { get; set; }
	
	        /// <summary>
	        /// 用户姓名
	        /// </summary>
	        [XmlElement("real_name")]
	        public string RealName { get; set; }
	
	        /// <summary>
	        /// 文件接收方名称
	        /// </summary>
	        [XmlElement("receiver_name")]
	        public string ReceiverName { get; set; }
	
	        /// <summary>
	        /// 文件接收方类型
	        /// </summary>
	        [XmlElement("receiver_type")]
	        public long ReceiverType { get; set; }
	
	        /// <summary>
	        /// 接收方类型翻译值
	        /// </summary>
	        [XmlElement("receiver_type_view")]
	        public string ReceiverTypeView { get; set; }
	
	        /// <summary>
	        /// 文件名
	        /// </summary>
	        [XmlElement("resource")]
	        public string Resource { get; set; }
	
	        /// <summary>
	        /// 文件类型
	        /// </summary>
	        [XmlElement("resource_extension")]
	        public string ResourceExtension { get; set; }
	
	        /// <summary>
	        /// 文件大小
	        /// </summary>
	        [XmlElement("resource_size")]
	        public long ResourceSize { get; set; }
	
	        /// <summary>
	        /// 记录状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 空间id
	        /// </summary>
	        [XmlElement("target_space_id")]
	        public long TargetSpaceId { get; set; }
	
	        /// <summary>
	        /// 员工的userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// ListAuditLogResultDomain Data Structure.
/// </summary>
[Serializable]

public class ListAuditLogResultDomain : TopObject
{
	        /// <summary>
	        /// 记录列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("audit_log_v_o")]
	        public List<AuditLogVODomain> List { get; set; }
}

    }
}
