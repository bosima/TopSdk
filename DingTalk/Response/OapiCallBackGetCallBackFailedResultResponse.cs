using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCallBackGetCallBackFailedResultResponse.
    /// </summary>
    public class OapiCallBackGetCallBackFailedResultResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 事件列表，一次最多200个
        /// </summary>
        [XmlArray("failed_list")]
        [XmlArrayItem("failed")]
        public List<FailedDomain> FailedList { get; set; }

        /// <summary>
        /// has_more
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

	/// <summary>
/// FailedDomain Data Structure.
/// </summary>
[Serializable]

public class FailedDomain : TopObject
{
	        /// <summary>
	        /// bpms_instance_change
	        /// </summary>
	        [XmlElement("bpms_instance_change")]
	        public string BpmsInstanceChange { get; set; }
	
	        /// <summary>
	        /// bpms_task_change
	        /// </summary>
	        [XmlElement("bpms_task_change")]
	        public string BpmsTaskChange { get; set; }
	
	        /// <summary>
	        /// 事件类型，有20种，“user_add_org”, “user_modify_org”, “user_leave_org”,“org_admin_add”, “org_admin_remove”, “org_dept_create”, “org_dept_modify”, “org_dept_remove”, “org_remove”, “chat_add_member”, “chat_remove_member”, “chat_quit”, “chat_update_owner”, “chat_update_title”, “chat_disband”,“chat_disband_microapp”, “check_in”,“bpms_task_change”,“bpms_instance_change”,“label_user_change”, “label_conf_add”, “label_conf_modify”,“label_conf_del”
	        /// </summary>
	        [XmlElement("call_back_tag")]
	        public string CallBackTag { get; set; }
	
	        /// <summary>
	        /// check_in
	        /// </summary>
	        [XmlElement("check_in")]
	        public string CheckIn { get; set; }
	
	        /// <summary>
	        /// data
	        /// </summary>
	        [XmlElement("data")]
	        public string Data { get; set; }
	
	        /// <summary>
	        /// event_time
	        /// </summary>
	        [XmlElement("event_time")]
	        public long EventTime { get; set; }
	
	        /// <summary>
	        /// org_admin_add
	        /// </summary>
	        [XmlElement("org_admin_add")]
	        public string OrgAdminAdd { get; set; }
	
	        /// <summary>
	        /// org_admin_remove
	        /// </summary>
	        [XmlElement("org_admin_remove")]
	        public string OrgAdminRemove { get; set; }
	
	        /// <summary>
	        /// org_change
	        /// </summary>
	        [XmlElement("org_change")]
	        public string OrgChange { get; set; }
	
	        /// <summary>
	        /// org_dept_create
	        /// </summary>
	        [XmlElement("org_dept_create")]
	        public string OrgDeptCreate { get; set; }
	
	        /// <summary>
	        /// org_dept_modify
	        /// </summary>
	        [XmlElement("org_dept_modify")]
	        public string OrgDeptModify { get; set; }
	
	        /// <summary>
	        /// org_dept_remove
	        /// </summary>
	        [XmlElement("org_dept_remove")]
	        public string OrgDeptRemove { get; set; }
	
	        /// <summary>
	        /// user_add_org
	        /// </summary>
	        [XmlElement("user_add_org")]
	        public string UserAddOrg { get; set; }
	
	        /// <summary>
	        /// user_leave_org
	        /// </summary>
	        [XmlElement("user_leave_org")]
	        public string UserLeaveOrg { get; set; }
	
	        /// <summary>
	        /// user_modify_org
	        /// </summary>
	        [XmlElement("user_modify_org")]
	        public string UserModifyOrg { get; set; }
}

    }
}
