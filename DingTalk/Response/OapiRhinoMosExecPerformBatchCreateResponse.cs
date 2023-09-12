using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosExecPerformBatchCreateResponse.
    /// </summary>
    public class OapiRhinoMosExecPerformBatchCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("external_msg_info")]
        public string ExternalMsgInfo { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("operation_perform_dto")]
        public List<OperationPerformDtoDomain> Model { get; set; }

	/// <summary>
/// OperationPerformDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OperationPerformDtoDomain : TopObject
{
	        /// <summary>
	        /// 是否生效
	        /// </summary>
	        [XmlElement("active")]
	        public string Active { get; set; }
	
	        /// <summary>
	        /// 批量id
	        /// </summary>
	        [XmlElement("batch_id")]
	        public long BatchId { get; set; }
	
	        /// <summary>
	        /// 上下文
	        /// </summary>
	        [XmlElement("context")]
	        public string Context { get; set; }
	
	        /// <summary>
	        /// 创建类型
	        /// </summary>
	        [XmlElement("create_type")]
	        public string CreateType { get; set; }
	
	        /// <summary>
	        /// 设备id
	        /// </summary>
	        [XmlArray("device_ids")]
	        [XmlArrayItem("number")]
	        public List<long> DeviceIds { get; set; }
	
	        /// <summary>
	        /// 实体id
	        /// </summary>
	        [XmlElement("entity_id")]
	        public long EntityId { get; set; }
	
	        /// <summary>
	        /// 实体类型
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
	
	        /// <summary>
	        /// flow版本
	        /// </summary>
	        [XmlElement("flow_version")]
	        public long FlowVersion { get; set; }
	
	        /// <summary>
	        /// 执行记录id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 工序类型
	        /// </summary>
	        [XmlElement("operation_type")]
	        public string OperationType { get; set; }
	
	        /// <summary>
	        /// 工序uid
	        /// </summary>
	        [XmlElement("operation_uid")]
	        public long OperationUid { get; set; }
	
	        /// <summary>
	        /// 订单id
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
	        /// 工序类型code
	        /// </summary>
	        [XmlElement("process_type_code")]
	        public string ProcessTypeCode { get; set; }
	
	        /// <summary>
	        /// 工序处理结束时间
	        /// </summary>
	        [XmlElement("processing_end_time")]
	        public string ProcessingEndTime { get; set; }
	
	        /// <summary>
	        /// 工序处理开始时间
	        /// </summary>
	        [XmlElement("processing_start_time")]
	        public string ProcessingStartTime { get; set; }
	
	        /// <summary>
	        /// 工段
	        /// </summary>
	        [XmlElement("section_code")]
	        public string SectionCode { get; set; }
	
	        /// <summary>
	        /// sourceId
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// source类型
	        /// </summary>
	        [XmlElement("source_type")]
	        public string SourceType { get; set; }
	
	        /// <summary>
	        /// 租户id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 工号
	        /// </summary>
	        [XmlArray("work_nos")]
	        [XmlArrayItem("string")]
	        public List<string> WorkNos { get; set; }
	
	        /// <summary>
	        /// 站位
	        /// </summary>
	        [XmlElement("workstation_code")]
	        public string WorkstationCode { get; set; }
}

    }
}
