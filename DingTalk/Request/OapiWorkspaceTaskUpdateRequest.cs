using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.task.update
    /// </summary>
    public class OapiWorkspaceTaskUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceTaskUpdateResponse>
    {
        /// <summary>
        /// 微应用agentId
        /// </summary>
        public Nullable<long> MicroappAgentId { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        public string OperatorUserid { get; set; }

        /// <summary>
        /// 请求入参
        /// </summary>
        public string Task { get; set; }

        public TaskUpdateDomain Task_ { set { this.Task = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 任务ID
        /// </summary>
        public string TaskId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.task.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("microapp_agent_id", this.MicroappAgentId);
            parameters.Add("operator_userid", this.OperatorUserid);
            parameters.Add("task", this.Task);
            parameters.Add("task_id", this.TaskId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("task", this.Task);
            RequestValidator.ValidateRequired("task_id", this.TaskId);
        }

	/// <summary>
/// TaskSystemPropertyDomain Data Structure.
/// </summary>
[Serializable]

public class TaskSystemPropertyDomain : TopObject
{
	        /// <summary>
	        /// APP 跳转连接
	        /// </summary>
	        [XmlElement("appUrl")]
	        public string AppUrl { get; set; }
	
	        /// <summary>
	        /// web 跳转连接
	        /// </summary>
	        [XmlElement("webUrl")]
	        public string WebUrl { get; set; }
}

	/// <summary>
/// TaskExtensionDomain Data Structure.
/// </summary>
[Serializable]

public class TaskExtensionDomain : TopObject
{
	        /// <summary>
	        /// 评论数
	        /// </summary>
	        [XmlElement("comment_count")]
	        public Nullable<long> CommentCount { get; set; }
	
	        /// <summary>
	        /// 附件地址
	        /// </summary>
	        [XmlElement("file_path")]
	        public string FilePath { get; set; }
	
	        /// <summary>
	        /// 用户可扩展的字段
	        /// </summary>
	        [XmlElement("other")]
	        public string Other { get; set; }
	
	        /// <summary>
	        /// 待办系统属性，主要包含接入方的详情页跳转链接
	        /// </summary>
	        [XmlElement("systemProperty")]
	        public TaskSystemPropertyDomain SystemProperty { get; set; }
}

	/// <summary>
/// TaskUpdateDomain Data Structure.
/// </summary>
[Serializable]

public class TaskUpdateDomain : TopObject
{
	        /// <summary>
	        /// 任务所属项目(虚拟企业），基于项目空间的项目
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 描述（传null不更新，传空串则清空原值）
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 执行者id（传null不更新，传空串则清空原值）
	        /// </summary>
	        [XmlElement("executor_userid")]
	        public string ExecutorUserid { get; set; }
	
	        /// <summary>
	        /// 任务的扩展字段
	        /// </summary>
	        [XmlElement("extension")]
	        public TaskExtensionDomain Extension { get; set; }
	
	        /// <summary>
	        /// 完成时间（传null不更新，传Date(0)，即1970-01-01T08:00:00.000+08:00则清空原值）
	        /// </summary>
	        [XmlElement("finish_date")]
	        public Nullable<DateTime> FinishDate { get; set; }
	
	        /// <summary>
	        /// 修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public Nullable<DateTime> GmtModified { get; set; }
	
	        /// <summary>
	        /// 是否归档
	        /// </summary>
	        [XmlElement("is_archived")]
	        public Nullable<bool> IsArchived { get; set; }
	
	        /// <summary>
	        /// 是否放入回收站
	        /// </summary>
	        [XmlElement("is_recycled")]
	        public Nullable<bool> IsRecycled { get; set; }
	
	        /// <summary>
	        /// 更新者id
	        /// </summary>
	        [XmlElement("modifier_userid")]
	        public string ModifierUserid { get; set; }
	
	        /// <summary>
	        /// 父任务id
	        /// </summary>
	        [XmlElement("parent_id")]
	        public string ParentId { get; set; }
	
	        /// <summary>
	        /// 计划结束时间（传null不更新，传Date(0)，即1970-01-01T08:00:00.000+08:00则清空原值）
	        /// </summary>
	        [XmlElement("plan_finish_date")]
	        public Nullable<DateTime> PlanFinishDate { get; set; }
	
	        /// <summary>
	        /// 计划开始时间（传null不更新，传Date(0)，即1970-01-01T08:00:00.000+08:00则清空原值）
	        /// </summary>
	        [XmlElement("plan_start_date")]
	        public Nullable<DateTime> PlanStartDate { get; set; }
	
	        /// <summary>
	        /// 优先级
	        /// </summary>
	        [XmlElement("priority")]
	        public Nullable<long> Priority { get; set; }
	
	        /// <summary>
	        /// 任务来源source
	        /// </summary>
	        [XmlElement("source")]
	        public string Source { get; set; }
	
	        /// <summary>
	        /// 来源id
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// 开始日期（传null不更新，传Date(0)，即1970-01-01T08:00:00.000+08:00则清空原值）
	        /// </summary>
	        [XmlElement("start_date")]
	        public Nullable<DateTime> StartDate { get; set; }
	
	        /// <summary>
	        /// 工作流状态id
	        /// </summary>
	        [XmlElement("status_id")]
	        public Nullable<long> StatusId { get; set; }
	
	        /// <summary>
	        /// 状态阶段: 开始阶段(0)，进行阶段(1)，完成阶段(2)
	        /// </summary>
	        [XmlElement("status_stage")]
	        public Nullable<long> StatusStage { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
	
	        /// <summary>
	        /// 任务类型分类:// 任务 TASK("task"),     // 需求     REQ("req"),     // 缺陷     BUG("bug"),     // 风险     RISK("risk"),     // 工作项     WORKITEM("workitem")
	        /// </summary>
	        [XmlElement("task_type_category")]
	        public string TaskTypeCategory { get; set; }
	
	        /// <summary>
	        /// 任务类型id
	        /// </summary>
	        [XmlElement("task_type_id")]
	        public Nullable<long> TaskTypeId { get; set; }
	
	        /// <summary>
	        /// 任务参与者列表
	        /// </summary>
	        [XmlArray("tracker_userids")]
	        [XmlArrayItem("string")]
	        public List<string> TrackerUserids { get; set; }
}

        #endregion
    }
}
