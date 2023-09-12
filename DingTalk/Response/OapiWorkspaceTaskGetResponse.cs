using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkspaceTaskGetResponse.
    /// </summary>
    public class OapiWorkspaceTaskGetResponse : DingTalkResponse
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
/// TaskExtensionDomain Data Structure.
/// </summary>
[Serializable]

public class TaskExtensionDomain : TopObject
{
	        /// <summary>
	        /// 评论数
	        /// </summary>
	        [XmlElement("comment_count")]
	        public string CommentCount { get; set; }
	
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
	        /// 创建者id
	        /// </summary>
	        [XmlElement("creator_userid")]
	        public string CreatorUserid { get; set; }
	
	        /// <summary>
	        /// 任务描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 执行者id
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
	        /// 计划完成时间
	        /// </summary>
	        [XmlElement("plan_finish_date")]
	        public string PlanFinishDate { get; set; }
	
	        /// <summary>
	        /// 计划开始时间
	        /// </summary>
	        [XmlElement("plan_start_date")]
	        public string PlanStartDate { get; set; }
	
	        /// <summary>
	        /// 优先级
	        /// </summary>
	        [XmlElement("priority")]
	        public long Priority { get; set; }
	
	        /// <summary>
	        /// 来源id
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_date")]
	        public string StartDate { get; set; }
	
	        /// <summary>
	        /// 工作流状态id
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
	        /// 任务类型id
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
