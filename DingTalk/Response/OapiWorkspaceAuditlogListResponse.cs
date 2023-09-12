using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkspaceAuditlogListResponse.
    /// </summary>
    public class OapiWorkspaceAuditlogListResponse : DingTalkResponse
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
        /// 返回值
        /// </summary>
        [XmlElement("result")]
        public OpenAuditLogDtoDomain Result { get; set; }

	/// <summary>
/// EventAuditLogDtoDomain Data Structure.
/// </summary>
[Serializable]

public class EventAuditLogDtoDomain : TopObject
{
	        /// <summary>
	        /// 操作类型
	        /// </summary>
	        [XmlElement("action")]
	        public string Action { get; set; }
	
	        /// <summary>
	        /// 文件id
	        /// </summary>
	        [XmlElement("biz_id")]
	        public string BizId { get; set; }
	
	        /// <summary>
	        /// 操作机器浏览器
	        /// </summary>
	        [XmlElement("browser")]
	        public string Browser { get; set; }
	
	        /// <summary>
	        /// 用户的钉钉id
	        /// </summary>
	        [XmlElement("ding_talk_id")]
	        public string DingTalkId { get; set; }
	
	        /// <summary>
	        /// 用户所在企业中的员工id
	        /// </summary>
	        [XmlElement("emp_id")]
	        public string EmpId { get; set; }
	
	        /// <summary>
	        /// 记录修改时间，unix时间戳，单位ms
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 操作机器ip
	        /// </summary>
	        [XmlElement("ip_address")]
	        public string IpAddress { get; set; }
	
	        /// <summary>
	        /// 操作者名字
	        /// </summary>
	        [XmlElement("operator_name")]
	        public string OperatorName { get; set; }
	
	        /// <summary>
	        /// 企业名称
	        /// </summary>
	        [XmlElement("org_name")]
	        public string OrgName { get; set; }
	
	        /// <summary>
	        /// 操作端
	        /// </summary>
	        [XmlElement("platform")]
	        public string Platform { get; set; }
	
	        /// <summary>
	        /// 项目名称
	        /// </summary>
	        [XmlElement("project_name")]
	        public string ProjectName { get; set; }
	
	        /// <summary>
	        /// 文件接收方名称
	        /// </summary>
	        [XmlElement("receiver_name")]
	        public string ReceiverName { get; set; }
	
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
	        public string ResourceSize { get; set; }
	
	        /// <summary>
	        /// 任务名称
	        /// </summary>
	        [XmlElement("task_name")]
	        public string TaskName { get; set; }
}

	/// <summary>
/// OpenAuditLogDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenAuditLogDtoDomain : TopObject
{
	        /// <summary>
	        /// 记录列表
	        /// </summary>
	        [XmlArray("log_list")]
	        [XmlArrayItem("event_audit_log_dto")]
	        public List<EventAuditLogDtoDomain> LogList { get; set; }
}

    }
}
