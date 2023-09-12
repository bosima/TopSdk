using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.layout.operationdefs.editassign
    /// </summary>
    public class OapiRhinoMosLayoutOperationdefsEditassignRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosLayoutOperationdefsEditassignResponse>
    {
        /// <summary>
        /// 分配信息修改明细列表
        /// </summary>
        public string AssignInfoModifyItems { get; set; }

        public List<AssignInfoModifyItemDomain> AssignInfoModifyItems_ { set { this.AssignInfoModifyItems = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 订单ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.layout.operationdefs.editassign";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("assign_info_modify_items", this.AssignInfoModifyItems);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("assign_info_modify_items", this.AssignInfoModifyItems);
            RequestValidator.ValidateObjectMaxListSize("assign_info_modify_items", this.AssignInfoModifyItems, 500);
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
/// AssignInfoModifyItemDomain Data Structure.
/// </summary>
[Serializable]

public class AssignInfoModifyItemDomain : TopObject
{
	        /// <summary>
	        /// 工序执行器分配列表
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
	        /// 工序唯一ID
	        /// </summary>
	        [XmlElement("operation_uid")]
	        public Nullable<long> OperationUid { get; set; }
	
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
