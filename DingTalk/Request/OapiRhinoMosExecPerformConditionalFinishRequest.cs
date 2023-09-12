using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.perform.conditional.finish
    /// </summary>
    public class OapiRhinoMosExecPerformConditionalFinishRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecPerformConditionalFinishResponse>
    {
        /// <summary>
        /// 执行设备ID列表
        /// </summary>
        public string DeviceIds { get; set; }

        /// <summary>
        /// 实体条件
        /// </summary>
        public string EntityCondition { get; set; }

        public EntityConditionDomain EntityCondition_ { set { this.EntityCondition = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 工序ID列表
        /// </summary>
        public string OperationUids { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 系统参数
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 执行员工列表
        /// </summary>
        public string WorkNos { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.perform.conditional.finish";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_ids", this.DeviceIds);
            parameters.Add("entity_condition", this.EntityCondition);
            parameters.Add("operation_uids", this.OperationUids);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("userid", this.Userid);
            parameters.Add("work_nos", this.WorkNos);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("device_ids", this.DeviceIds, 20);
            RequestValidator.ValidateRequired("entity_condition", this.EntityCondition);
            RequestValidator.ValidateMaxListSize("operation_uids", this.OperationUids, 20);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
            RequestValidator.ValidateMaxListSize("work_nos", this.WorkNos, 20);
        }

	/// <summary>
/// SourceDomain Data Structure.
/// </summary>
[Serializable]

public class SourceDomain : TopObject
{
	        /// <summary>
	        /// 实体来源ID
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// 实体来源类型
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
	        /// 实体ID列表
	        /// </summary>
	        [XmlArray("entity_ids")]
	        [XmlArrayItem("number")]
	        public List<string> EntityIds { get; set; }
	
	        /// <summary>
	        /// 实体来源
	        /// </summary>
	        [XmlElement("entity_source")]
	        public SourceDomain EntitySource { get; set; }
	
	        /// <summary>
	        /// 实体类型
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
}

        #endregion
    }
}
