using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.perform.batch.create
    /// </summary>
    public class OapiRhinoMosExecPerformBatchCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecPerformBatchCreateResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string BatchCreateOperationReq { get; set; }

        public BatchCreateOperationWithEntityReqDomain BatchCreateOperationReq_ { set { this.BatchCreateOperationReq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.perform.batch.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("batch_create_operation_req", this.BatchCreateOperationReq);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// SourceDomain Data Structure.
/// </summary>
[Serializable]

public class SourceDomain : TopObject
{
	        /// <summary>
	        /// sourceId
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// sourceType
	        /// </summary>
	        [XmlElement("source_type")]
	        public string SourceType { get; set; }
}

	/// <summary>
/// EntityConditionDomain Data Structure.
/// </summary>
[Serializable]

public class EntityConditionDomain : TopObject
{
	        /// <summary>
	        /// 实体ids
	        /// </summary>
	        [XmlArray("entity_ids")]
	        [XmlArrayItem("number")]
	        public List<string> EntityIds { get; set; }
	
	        /// <summary>
	        /// 实体来源（暂未支持）
	        /// </summary>
	        [XmlElement("entity_source")]
	        public SourceDomain EntitySource { get; set; }
	
	        /// <summary>
	        /// 实体type
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
}

	/// <summary>
/// PerformOperationReqDomain Data Structure.
/// </summary>
[Serializable]

public class PerformOperationReqDomain : TopObject
{
	        /// <summary>
	        /// 上下文
	        /// </summary>
	        [XmlElement("context")]
	        public string Context { get; set; }
	
	        /// <summary>
	        /// 设备id
	        /// </summary>
	        [XmlArray("device_ids")]
	        [XmlArrayItem("number")]
	        public List<string> DeviceIds { get; set; }
	
	        /// <summary>
	        /// flow版本
	        /// </summary>
	        [XmlElement("flow_version")]
	        public Nullable<long> FlowVersion { get; set; }
	
	        /// <summary>
	        /// 工序类型
	        /// </summary>
	        [XmlElement("operation_type")]
	        public string OperationType { get; set; }
	
	        /// <summary>
	        /// 工序唯一id
	        /// </summary>
	        [XmlElement("operation_uid")]
	        public Nullable<long> OperationUid { get; set; }
	
	        /// <summary>
	        /// 执行状态
	        /// </summary>
	        [XmlElement("perform_status")]
	        public string PerformStatus { get; set; }
	
	        /// <summary>
	        /// 优先级
	        /// </summary>
	        [XmlElement("priority")]
	        public Nullable<long> Priority { get; set; }
	
	        /// <summary>
	        /// 执行耗时
	        /// </summary>
	        [XmlElement("process_cost_time")]
	        public string ProcessCostTime { get; set; }
	
	        /// <summary>
	        /// 执行完成时间
	        /// </summary>
	        [XmlElement("process_end_time")]
	        public Nullable<DateTime> ProcessEndTime { get; set; }
	
	        /// <summary>
	        /// 执行开始时间
	        /// </summary>
	        [XmlElement("process_start_time")]
	        public Nullable<DateTime> ProcessStartTime { get; set; }
	
	        /// <summary>
	        /// 工序类型码
	        /// </summary>
	        [XmlElement("process_type_code")]
	        public string ProcessTypeCode { get; set; }
	
	        /// <summary>
	        /// 工段
	        /// </summary>
	        [XmlElement("section_code")]
	        public string SectionCode { get; set; }
	
	        /// <summary>
	        /// 工号
	        /// </summary>
	        [XmlArray("work_nos")]
	        [XmlArrayItem("string")]
	        public List<string> WorkNos { get; set; }
	
	        /// <summary>
	        /// 工作站
	        /// </summary>
	        [XmlElement("workstation_code")]
	        public string WorkstationCode { get; set; }
}

	/// <summary>
/// BatchCreateOperationWithEntityReqDomain Data Structure.
/// </summary>
[Serializable]

public class BatchCreateOperationWithEntityReqDomain : TopObject
{
	        /// <summary>
	        /// 实体条件
	        /// </summary>
	        [XmlElement("entity_condition")]
	        public EntityConditionDomain EntityCondition { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
	
	        /// <summary>
	        /// 工序请求
	        /// </summary>
	        [XmlArray("perform_operation_reqs")]
	        [XmlArrayItem("perform_operation_req")]
	        public List<PerformOperationReqDomain> PerformOperationReqs { get; set; }
	
	        /// <summary>
	        /// 来源
	        /// </summary>
	        [XmlElement("source")]
	        public SourceDomain Source { get; set; }
	
	        /// <summary>
	        /// 租户id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
