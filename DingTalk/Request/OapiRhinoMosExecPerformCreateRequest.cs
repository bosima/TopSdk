using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.perform.create
    /// </summary>
    public class OapiRhinoMosExecPerformCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecPerformCreateResponse>
    {
        /// <summary>
        /// 工序执行记录
        /// </summary>
        public string Operations { get; set; }

        public List<OperationReqDomain> Operations_ { set { this.Operations = TopUtils.ObjectToJson(value); } } 

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
            return "dingtalk.oapi.rhino.mos.exec.perform.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("operations", this.Operations);
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
            RequestValidator.ValidateRequired("operations", this.Operations);
            RequestValidator.ValidateObjectMaxListSize("operations", this.Operations, 500);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

	/// <summary>
/// OperationReqDomain Data Structure.
/// </summary>
[Serializable]

public class OperationReqDomain : TopObject
{
	        /// <summary>
	        /// 执行上下文
	        /// </summary>
	        [XmlElement("context")]
	        public string Context { get; set; }
	
	        /// <summary>
	        /// 设备ID列表
	        /// </summary>
	        [XmlArray("device_ids")]
	        [XmlArrayItem("number")]
	        public List<string> DeviceIds { get; set; }
	
	        /// <summary>
	        /// 实体ID
	        /// </summary>
	        [XmlElement("entity_id")]
	        public Nullable<long> EntityId { get; set; }
	
	        /// <summary>
	        /// 实体类型
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
	
	        /// <summary>
	        /// 排位布局版本
	        /// </summary>
	        [XmlElement("flow_version")]
	        public Nullable<long> FlowVersion { get; set; }
	
	        /// <summary>
	        /// 工序类型
	        /// </summary>
	        [XmlElement("operation_type")]
	        public string OperationType { get; set; }
	
	        /// <summary>
	        /// 工序ID
	        /// </summary>
	        [XmlElement("operation_uid")]
	        public Nullable<long> OperationUid { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
	
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
	        public Nullable<long> Priority { get; set; }
	
	        /// <summary>
	        /// 工序执行耗时，单位秒
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
	        /// 工序能力类型
	        /// </summary>
	        [XmlElement("process_type_code")]
	        public string ProcessTypeCode { get; set; }
	
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

        #endregion
    }
}
