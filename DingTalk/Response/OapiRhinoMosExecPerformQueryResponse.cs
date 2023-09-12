using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosExecPerformQueryResponse.
    /// </summary>
    public class OapiRhinoMosExecPerformQueryResponse : DingTalkResponse
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
        /// 创建后的工段执行记录
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("operation_perform_dto")]
        public List<OperationPerformDtoDomain> Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OperationPerformDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OperationPerformDtoDomain : TopObject
{
	        /// <summary>
	        /// 是否有效
	        /// </summary>
	        [XmlElement("active")]
	        public string Active { get; set; }
	
	        /// <summary>
	        /// 分批ID
	        /// </summary>
	        [XmlElement("batch_id")]
	        public long BatchId { get; set; }
	
	        /// <summary>
	        /// 上下文
	        /// </summary>
	        [XmlElement("context")]
	        public string Context { get; set; }
	
	        /// <summary>
	        /// 创建类型，是新建的还是已存在的
	        /// </summary>
	        [XmlElement("create_type")]
	        public string CreateType { get; set; }
	
	        /// <summary>
	        /// 设备ID列表
	        /// </summary>
	        [XmlArray("device_ids")]
	        [XmlArrayItem("number")]
	        public List<long> DeviceIds { get; set; }
	
	        /// <summary>
	        /// 实例ID
	        /// </summary>
	        [XmlElement("entity_id")]
	        public long EntityId { get; set; }
	
	        /// <summary>
	        /// 实体类型
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
	
	        /// <summary>
	        /// 排位布局版本
	        /// </summary>
	        [XmlElement("flow_version")]
	        public long FlowVersion { get; set; }
	
	        /// <summary>
	        /// 工序执行ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 工序类型
	        /// </summary>
	        [XmlElement("operation_type")]
	        public string OperationType { get; set; }
	
	        /// <summary>
	        /// 工序ID
	        /// </summary>
	        [XmlElement("operation_uid")]
	        public long OperationUid { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 执行状态
	        /// </summary>
	        [XmlElement("perform_status")]
	        public string PerformStatus { get; set; }
	
	        /// <summary>
	        /// 执行类型
	        /// </summary>
	        [XmlElement("perform_type")]
	        public string PerformType { get; set; }
	
	        /// <summary>
	        /// 优先级
	        /// </summary>
	        [XmlElement("priority")]
	        public long Priority { get; set; }
	
	        /// <summary>
	        /// 工序执行耗时
	        /// </summary>
	        [XmlElement("process_cost_time")]
	        public string ProcessCostTime { get; set; }
	
	        /// <summary>
	        /// 工序能力类型
	        /// </summary>
	        [XmlElement("process_type_code")]
	        public string ProcessTypeCode { get; set; }
	
	        /// <summary>
	        /// 工序执行结束时间
	        /// </summary>
	        [XmlElement("processing_end_time")]
	        public string ProcessingEndTime { get; set; }
	
	        /// <summary>
	        /// 工序执行开始时间
	        /// </summary>
	        [XmlElement("processing_start_time")]
	        public string ProcessingStartTime { get; set; }
	
	        /// <summary>
	        /// 工段
	        /// </summary>
	        [XmlElement("section_code")]
	        public string SectionCode { get; set; }
	
	        /// <summary>
	        /// 来源ID
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// 来源类型
	        /// </summary>
	        [XmlElement("source_type")]
	        public string SourceType { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 执行人工号
	        /// </summary>
	        [XmlArray("work_nos")]
	        [XmlArrayItem("string")]
	        public List<string> WorkNos { get; set; }
	
	        /// <summary>
	        /// 执行工位
	        /// </summary>
	        [XmlElement("workstation_code")]
	        public string WorkstationCode { get; set; }
}

    }
}
