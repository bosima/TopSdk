using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkspaceTaskCreateResponse.
    /// </summary>
    public class OapiWorkspaceTaskCreateResponse : DingTalkResponse
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
        /// 响应结果
        /// </summary>
        [XmlElement("result")]
        public TaskDomain Result { get; set; }

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
	        /// 来自钉钉群 id
	        /// </summary>
	        [XmlElement("groupId")]
	        public string GroupId { get; set; }
	
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
	        /// 评论数量
	        /// </summary>
	        [XmlElement("comment_count")]
	        public long CommentCount { get; set; }
	
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
/// TaskDomain Data Structure.
/// </summary>
[Serializable]

public class TaskDomain : TopObject
{
	        /// <summary>
	        /// 归属企业id
	        /// </summary>
	        [XmlElement("belong_corp_id")]
	        public string BelongCorpId { get; set; }
	
	        /// <summary>
	        /// 业务标识
	        /// </summary>
	        [XmlElement("biz_tag")]
	        public string BizTag { get; set; }
	
	        /// <summary>
	        /// 任务所属项目(虚拟企业），基于项目空间的项目
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 创建者id, 传staffId（工号）
	        /// </summary>
	        [XmlElement("creator_userid")]
	        public string CreatorUserid { get; set; }
	
	        /// <summary>
	        /// 任务描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 执行者id, 传staffId（工号）
	        /// </summary>
	        [XmlElement("executor_userid")]
	        public string ExecutorUserid { get; set; }
	
	        /// <summary>
	        /// 任务的扩展字段
	        /// </summary>
	        [XmlElement("extension")]
	        public TaskExtensionDomain Extension { get; set; }
	
	        /// <summary>
	        /// 完成时间
	        /// </summary>
	        [XmlElement("finish_date")]
	        public string FinishDate { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 是否归档
	        /// </summary>
	        [XmlElement("is_archived")]
	        public bool IsArchived { get; set; }
	
	        /// <summary>
	        /// 是否放入回收站
	        /// </summary>
	        [XmlElement("is_recycled")]
	        public bool IsRecycled { get; set; }
	
	        /// <summary>
	        /// 更新者id, 传staffId（工号）
	        /// </summary>
	        [XmlElement("modifier_userid")]
	        public string ModifierUserid { get; set; }
	
	        /// <summary>
	        /// 父任务id
	        /// </summary>
	        [XmlElement("parent_id")]
	        public string ParentId { get; set; }
	
	        /// <summary>
	        /// 任务计划完成时间
	        /// </summary>
	        [XmlElement("plan_finish_date")]
	        public string PlanFinishDate { get; set; }
	
	        /// <summary>
	        /// 任务计划开始时间
	        /// </summary>
	        [XmlElement("plan_start_date")]
	        public string PlanStartDate { get; set; }
	
	        /// <summary>
	        /// 优先级, 较低:10, 普通:20, 紧急:30, 非常紧急:40
	        /// </summary>
	        [XmlElement("priority")]
	        public long Priority { get; set; }
	
	        /// <summary>
	        /// 任务来源source
	        /// </summary>
	        [XmlElement("source")]
	        public string Source { get; set; }
	
	        /// <summary>
	        /// 此字段用于数据迁移的场景，表示任务在源系统中的唯一ID
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_date")]
	        public string StartDate { get; set; }
	
	        /// <summary>
	        /// 状态id，工作流状态, 可以为空
	        /// </summary>
	        [XmlElement("status_id")]
	        public long StatusId { get; set; }
	
	        /// <summary>
	        /// 状态阶段: 开始阶段(0)，进行阶段(1)，完成阶段(2)
	        /// </summary>
	        [XmlElement("status_stage")]
	        public long StatusStage { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
	
	        /// <summary>
	        /// 任务id
	        /// </summary>
	        [XmlElement("task_id")]
	        public string TaskId { get; set; }
	
	        /// <summary>
	        /// 任务类型分类:// 任务 TASK("task"),     // 需求     REQ("req"),     // 缺陷     BUG("bug"),     // 风险     RISK("risk"),     // 工作项     WORKITEM("workitem")
	        /// </summary>
	        [XmlElement("task_type_category")]
	        public string TaskTypeCategory { get; set; }
	
	        /// <summary>
	        /// 任务类型id，任务类型，可以不传
	        /// </summary>
	        [XmlElement("task_type_id")]
	        public long TaskTypeId { get; set; }
	
	        /// <summary>
	        /// 任务参与者列表
	        /// </summary>
	        [XmlArray("tracker_userids")]
	        [XmlArrayItem("string")]
	        public List<string> TrackerUserids { get; set; }
}

    }
}
