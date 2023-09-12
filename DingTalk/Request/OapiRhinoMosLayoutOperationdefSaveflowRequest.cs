using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.layout.operationdef.saveflow
    /// </summary>
    public class OapiRhinoMosLayoutOperationdefSaveflowRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosLayoutOperationdefSaveflowResponse>
    {
        /// <summary>
        /// 是否生效
        /// </summary>
        public Nullable<bool> Active { get; set; }

        /// <summary>
        /// 工序版本(指定版本时版本如果已经存在则幂等)
        /// </summary>
        public Nullable<long> FlowVersion { get; set; }

        /// <summary>
        /// 工序定义列表
        /// </summary>
        public string OperationDefs { get; set; }

        public List<OperationDefDtoDomain> OperationDefs_ { set { this.OperationDefs = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 订单ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 是否暂存
        /// </summary>
        public Nullable<bool> TmpSave { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.layout.operationdef.saveflow";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("active", this.Active);
            parameters.Add("flow_version", this.FlowVersion);
            parameters.Add("operation_defs", this.OperationDefs);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("source", this.Source);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("tmp_save", this.TmpSave);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("active", this.Active);
            RequestValidator.ValidateRequired("operation_defs", this.OperationDefs);
            RequestValidator.ValidateObjectMaxListSize("operation_defs", this.OperationDefs, 500);
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

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
	        public Nullable<long> OrderNum { get; set; }
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
	        public Nullable<long> DeviceId { get; set; }
	
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
	        /// 是否需要自动调度
	        /// </summary>
	        [XmlElement("auto_schedule")]
	        public Nullable<bool> AutoSchedule { get; set; }
	
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
	        public Nullable<long> FlowId { get; set; }
	
	        /// <summary>
	        /// 工序版本(指定版本时版本如果已经存在则幂等)
	        /// </summary>
	        [XmlElement("flow_version")]
	        public Nullable<long> FlowVersion { get; set; }
	
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
	        /// 后续工序ID列表（只用于返回，保存请设置nextVirtualIds）
	        /// </summary>
	        [XmlArray("next_operation_uids")]
	        [XmlArrayItem("number")]
	        public List<string> NextOperationUids { get; set; }
	
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
	        /// 工序唯一ID（保存时已存在则复用，不存在会自增）
	        /// </summary>
	        [XmlElement("operation_uid")]
	        public Nullable<long> OperationUid { get; set; }
	
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
	        public Nullable<bool> Skip { get; set; }
	
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

        #endregion
    }
}
