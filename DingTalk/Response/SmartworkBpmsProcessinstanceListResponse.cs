using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// SmartworkBpmsProcessinstanceListResponse.
    /// </summary>
    public class SmartworkBpmsProcessinstanceListResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// FormComponentValueVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormComponentValueVoDomain : TopObject
{
	        /// <summary>
	        /// 表单标签名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 表单标签值
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
	        /// 审批人列表
	        /// </summary>
	        [XmlArray("approver_userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> ApproverUseridList { get; set; }
	
	        /// <summary>
	        /// 流程实例业务编号
	        /// </summary>
	        [XmlElement("business_id")]
	        public string BusinessId { get; set; }
	
	        /// <summary>
	        /// 抄送人列表
	        /// </summary>
	        [XmlArray("cc_userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> CcUseridList { get; set; }
	
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
	        /// 审批表单变量组
	        /// </summary>
	        [XmlArray("form_component_values")]
	        [XmlArrayItem("form_component_value_vo")]
	        public List<FormComponentValueVoDomain> FormComponentValues { get; set; }
	
	        /// <summary>
	        /// 发起人部门id
	        /// </summary>
	        [XmlElement("originator_dept_id")]
	        public string OriginatorDeptId { get; set; }
	
	        /// <summary>
	        /// 发起人userid
	        /// </summary>
	        [XmlElement("originator_userid")]
	        public string OriginatorUserid { get; set; }
	
	        /// <summary>
	        /// 审批实例id
	        /// </summary>
	        [XmlElement("process_instance_id")]
	        public string ProcessInstanceId { get; set; }
	
	        /// <summary>
	        /// 审批结果，分为agree和refuse
	        /// </summary>
	        [XmlElement("process_instance_result")]
	        public string ProcessInstanceResult { get; set; }
	
	        /// <summary>
	        /// 审批状态，分为NEW（刚创建）|RUNNING（运行中）|TERMINATED（被终止）|COMPLETED（完成）|CANCELED（取消）
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("process_instance_top_vo")]
	        public List<ProcessInstanceTopVoDomain> List { get; set; }
	
	        /// <summary>
	        /// 表示下次查询的游标，当返回结果没有该字段时表示没有更多数据了
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
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
	        /// result
	        /// </summary>
	        [XmlElement("result")]
	        public PageResultDomain Result { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
