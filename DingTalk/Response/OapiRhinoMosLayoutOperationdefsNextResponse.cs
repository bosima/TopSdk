using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosLayoutOperationdefsNextResponse.
    /// </summary>
    public class OapiRhinoMosLayoutOperationdefsNextResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误提示
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 工序定义图
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("operation_def_dto")]
        public List<OperationDefDtoDomain> Result { get; set; }

	/// <summary>
/// OperationExecutorAssignDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OperationExecutorAssignDtoDomain : TopObject
{
	        /// <summary>
	        /// 工序执行器ID
	        /// </summary>
	        [XmlElement("executor_id")]
	        public string ExecutorId { get; set; }
	
	        /// <summary>
	        /// 排序值
	        /// </summary>
	        [XmlElement("order_num")]
	        public long OrderNum { get; set; }
}

	/// <summary>
/// DeviceAssignDtoDomain Data Structure.
/// </summary>
[Serializable]

public class DeviceAssignDtoDomain : TopObject
{
	        /// <summary>
	        /// 设备ID
	        /// </summary>
	        [XmlElement("device_id")]
	        public long DeviceId { get; set; }
	
	        /// <summary>
	        /// 设备模型ID
	        /// </summary>
	        [XmlElement("device_model_id")]
	        public string DeviceModelId { get; set; }
	
	        /// <summary>
	        /// 设备模型名称
	        /// </summary>
	        [XmlElement("device_model_name")]
	        public string DeviceModelName { get; set; }
	
	        /// <summary>
	        /// 设备模型版本
	        /// </summary>
	        [XmlElement("device_model_version")]
	        public string DeviceModelVersion { get; set; }
}

	/// <summary>
/// WorkerAssignDtoDomain Data Structure.
/// </summary>
[Serializable]

public class WorkerAssignDtoDomain : TopObject
{
	        /// <summary>
	        /// 姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 工号
	        /// </summary>
	        [XmlElement("work_no")]
	        public string WorkNo { get; set; }
}

	/// <summary>
/// WorkstationAssignDtoDomain Data Structure.
/// </summary>
[Serializable]

public class WorkstationAssignDtoDomain : TopObject
{
	        /// <summary>
	        /// 站位编码
	        /// </summary>
	        [XmlElement("workstation_code")]
	        public string WorkstationCode { get; set; }
}

	/// <summary>
/// WorkUnitDtoDomain Data Structure.
/// </summary>
[Serializable]

public class WorkUnitDtoDomain : TopObject
{
	        /// <summary>
	        /// 设备分配列表
	        /// </summary>
	        [XmlArray("device_assigns")]
	        [XmlArrayItem("device_assign_dto")]
	        public List<DeviceAssignDtoDomain> DeviceAssigns { get; set; }
	
	        /// <summary>
	        /// 人员分配列表
	        /// </summary>
	        [XmlArray("worker_assigns")]
	        [XmlArrayItem("worker_assign_dto")]
	        public List<WorkerAssignDtoDomain> WorkerAssigns { get; set; }
	
	        /// <summary>
	        /// 站位分配
	        /// </summary>
	        [XmlArray("workstation_assigns")]
	        [XmlArrayItem("workstation_assign_dto")]
	        public List<WorkstationAssignDtoDomain> WorkstationAssigns { get; set; }
}

	/// <summary>
/// OperationDefDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OperationDefDtoDomain : TopObject
{
	        /// <summary>
	        /// 适用尺码
	        /// </summary>
	        [XmlElement("applicable_size_code")]
	        public string ApplicableSizeCode { get; set; }
	
	        /// <summary>
	        /// 是否需要调度
	        /// </summary>
	        [XmlElement("auto_schedule")]
	        public bool AutoSchedule { get; set; }
	
	        /// <summary>
	        /// 业务编码
	        /// </summary>
	        [XmlElement("biz_code")]
	        public string BizCode { get; set; }
	
	        /// <summary>
	        /// 业务来源
	        /// </summary>
	        [XmlElement("biz_source")]
	        public string BizSource { get; set; }
	
	        /// <summary>
	        /// 进入条件：ANY_MATCH/ALL_MATCH
	        /// </summary>
	        [XmlElement("enter_condition")]
	        public string EnterCondition { get; set; }
	
	        /// <summary>
	        /// 执行系统
	        /// </summary>
	        [XmlElement("exec_system")]
	        public string ExecSystem { get; set; }
	
	        /// <summary>
	        /// PaaSflowID（只用于返回，保存会自增）
	        /// </summary>
	        [XmlElement("flow_id")]
	        public long FlowId { get; set; }
	
	        /// <summary>
	        /// 工序定义版本
	        /// </summary>
	        [XmlElement("flow_version")]
	        public long FlowVersion { get; set; }
	
	        /// <summary>
	        /// 工序名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 后续工序外部ID列表
	        /// </summary>
	        [XmlArray("next_operation_external_ids")]
	        [XmlArrayItem("string")]
	        public List<string> NextOperationExternalIds { get; set; }
	
	        /// <summary>
	        /// 后续工序唯一ID列表
	        /// </summary>
	        [XmlArray("next_operation_uids")]
	        [XmlArrayItem("number")]
	        public List<long> NextOperationUids { get; set; }
	
	        /// <summary>
	        /// 工序执行器分配
	        /// </summary>
	        [XmlArray("operation_executor_assigns")]
	        [XmlArrayItem("operation_executor_assign_dto")]
	        public List<OperationExecutorAssignDtoDomain> OperationExecutorAssigns { get; set; }
	
	        /// <summary>
	        /// 工序外部ID
	        /// </summary>
	        [XmlElement("operation_external_id")]
	        public string OperationExternalId { get; set; }
	
	        /// <summary>
	        /// 工序类型：ASSIST/QUALITY_INSPECT/TECHNOLOGY
	        /// </summary>
	        [XmlElement("operation_type")]
	        public string OperationType { get; set; }
	
	        /// <summary>
	        /// 工序唯一ID
	        /// </summary>
	        [XmlElement("operation_uid")]
	        public long OperationUid { get; set; }
	
	        /// <summary>
	        /// 工序能力类型：SJ/PP/TR等
	        /// </summary>
	        [XmlElement("process_type_code")]
	        public string ProcessTypeCode { get; set; }
	
	        /// <summary>
	        /// 工段CODE：F-SL/C..
	        /// </summary>
	        [XmlElement("section_code")]
	        public string SectionCode { get; set; }
	
	        /// <summary>
	        /// 工段名称：缝制-碎料/裁床..
	        /// </summary>
	        [XmlElement("section_name")]
	        public string SectionName { get; set; }
	
	        /// <summary>
	        /// 是否跳过(不生产)
	        /// </summary>
	        [XmlElement("skip")]
	        public bool Skip { get; set; }
	
	        /// <summary>
	        /// 标准工时/秒
	        /// </summary>
	        [XmlElement("std_cost")]
	        public string StdCost { get; set; }
	
	        /// <summary>
	        /// 分配单元列表
	        /// </summary>
	        [XmlArray("work_units")]
	        [XmlArrayItem("work_unit_dto")]
	        public List<WorkUnitDtoDomain> WorkUnits { get; set; }
}

    }
}
