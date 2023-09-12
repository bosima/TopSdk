using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// SmartworkBpmsProcessinstanceGetResponse.
    /// </summary>
    public class SmartworkBpmsProcessinstanceGetResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// OperationRecordsVoDomain Data Structure.
/// </summary>
[Serializable]

public class OperationRecordsVoDomain : TopObject
{
	        /// <summary>
	        /// 时间
	        /// </summary>
	        [XmlElement("date")]
	        public string Date { get; set; }
	
	        /// <summary>
	        /// 操作结果，分为AGREE（同意），REFUSE（拒绝）
	        /// </summary>
	        [XmlElement("operation_result")]
	        public string OperationResult { get; set; }
	
	        /// <summary>
	        /// 操作类型，分为EXECUTE_TASK_NORMAL（正常执行任务），EXECUTE_TASK_AGENT（代理人执行任务），APPEND_TASK_BEFORE（前加签任务），APPEND_TASK_AFTER（后加签任务），REDIRECT_TASK（转交任务），START_PROCESS_INSTANCE（发起流程实例），TERMINATE_PROCESS_INSTANCE（终止(撤销)流程实例），FINISH_PROCESS_INSTANCE（结束流程实例），ADD_REMARK（添加评论）
	        /// </summary>
	        [XmlElement("operation_type")]
	        public string OperationType { get; set; }
	
	        /// <summary>
	        /// 评论
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 操作人
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// TaskTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class TaskTopVoDomain : TopObject
{
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public string CreateTime { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("finish_time")]
	        public string FinishTime { get; set; }
	
	        /// <summary>
	        /// 结果，分为AGREE（同意），REFUSE（拒绝），REDIRECTED（转交）
	        /// </summary>
	        [XmlElement("task_result")]
	        public string TaskResult { get; set; }
	
	        /// <summary>
	        /// 任务状态，分为NEW（未启动），RUNNING（处理中），PAUSED（暂停），CANCELED（取消），COMPLETED（完成），TERMINATED（终止）
	        /// </summary>
	        [XmlElement("task_status")]
	        public string TaskStatus { get; set; }
	
	        /// <summary>
	        /// 任务节点id
	        /// </summary>
	        [XmlElement("taskid")]
	        public string Taskid { get; set; }
	
	        /// <summary>
	        /// 任务处理人
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// FormComponentValueVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormComponentValueVoDomain : TopObject
{
	        /// <summary>
	        /// 组件类型
	        /// </summary>
	        [XmlElement("component_type")]
	        public string ComponentType { get; set; }
	
	        /// <summary>
	        /// 标签扩展值
	        /// </summary>
	        [XmlElement("ext_value")]
	        public string ExtValue { get; set; }
	
	        /// <summary>
	        /// 组件id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 标签名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 标签值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// ProcessInstanceTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessInstanceTopVoDomain : TopObject
{
	        /// <summary>
	        /// 审批人
	        /// </summary>
	        [XmlArray("approver_userids")]
	        [XmlArrayItem("string")]
	        public List<string> ApproverUserids { get; set; }
	
	        /// <summary>
	        /// 审批附属实例列表，当已经通过的审批实例被修改或撤销，会生成一个新的实例，作为原有审批实例的附属。如果想知道当前已经通过的审批实例的状态，可以依次遍历它的附属列表，查询里面每个实例的biz_action
	        /// </summary>
	        [XmlArray("attached_process_instance_ids")]
	        [XmlArrayItem("string")]
	        public List<string> AttachedProcessInstanceIds { get; set; }
	
	        /// <summary>
	        /// 审批实例业务动作,MODIFY表示该审批实例是基于原来的实例修改而来，REVOKE表示该审批实例是由原来的实例撤销后重新发起的,NONE表示正常发起
	        /// </summary>
	        [XmlElement("biz_action")]
	        public string BizAction { get; set; }
	
	        /// <summary>
	        /// 审批实例业务编号
	        /// </summary>
	        [XmlElement("business_id")]
	        public string BusinessId { get; set; }
	
	        /// <summary>
	        /// 抄送人
	        /// </summary>
	        [XmlArray("cc_userids")]
	        [XmlArrayItem("string")]
	        public List<string> CcUserids { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public string CreateTime { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("finish_time")]
	        public string FinishTime { get; set; }
	
	        /// <summary>
	        /// 表单详情列表
	        /// </summary>
	        [XmlArray("form_component_values")]
	        [XmlArrayItem("form_component_value_vo")]
	        public List<FormComponentValueVoDomain> FormComponentValues { get; set; }
	
	        /// <summary>
	        /// 操作记录列表
	        /// </summary>
	        [XmlArray("operation_records")]
	        [XmlArrayItem("operation_records_vo")]
	        public List<OperationRecordsVoDomain> OperationRecords { get; set; }
	
	        /// <summary>
	        /// 发起部门
	        /// </summary>
	        [XmlElement("originator_dept_id")]
	        public string OriginatorDeptId { get; set; }
	
	        /// <summary>
	        /// 发起部门
	        /// </summary>
	        [XmlElement("originator_dept_name")]
	        public string OriginatorDeptName { get; set; }
	
	        /// <summary>
	        /// 发起人
	        /// </summary>
	        [XmlElement("originator_userid")]
	        public string OriginatorUserid { get; set; }
	
	        /// <summary>
	        /// 审批结果，分为agree和refuse
	        /// </summary>
	        [XmlElement("result")]
	        public string Result { get; set; }
	
	        /// <summary>
	        /// 审批状态，分为NEW（刚创建）|RUNNING（运行中）|TERMINATED（被终止）|COMPLETED（完成）|CANCELED（取消）
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 任务列表
	        /// </summary>
	        [XmlArray("tasks")]
	        [XmlArrayItem("task_top_vo")]
	        public List<TaskTopVoDomain> Tasks { get; set; }
	
	        /// <summary>
	        /// 审批实例标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 实例详情
	        /// </summary>
	        [XmlElement("process_instance")]
	        public ProcessInstanceTopVoDomain ProcessInstance { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
