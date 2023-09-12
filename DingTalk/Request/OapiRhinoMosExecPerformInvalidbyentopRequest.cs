using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.perform.invalidbyentop
    /// </summary>
    public class OapiRhinoMosExecPerformInvalidbyentopRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecPerformInvalidbyentopResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Req { get; set; }

        public SpecificEntitiesAndSpecificOperationsReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.perform.invalidbyentop";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("req", this.Req);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("req", this.Req);
        }

	/// <summary>
/// EntityOperationDomain Data Structure.
/// </summary>
[Serializable]

public class EntityOperationDomain : TopObject
{
	        /// <summary>
	        /// 实体ID
	        /// </summary>
	        [XmlElement("entity_id")]
	        public Nullable<long> EntityId { get; set; }
	
	        /// <summary>
	        /// 工序ID
	        /// </summary>
	        [XmlElement("operation_uid")]
	        public Nullable<long> OperationUid { get; set; }
}

	/// <summary>
/// SpecificEntitiesAndSpecificOperationsReqDomain Data Structure.
/// </summary>
[Serializable]

public class SpecificEntitiesAndSpecificOperationsReqDomain : TopObject
{
	        /// <summary>
	        /// 实体和工序
	        /// </summary>
	        [XmlArray("entity_operations")]
	        [XmlArrayItem("entity_operation")]
	        public List<EntityOperationDomain> EntityOperations { get; set; }
	
	        /// <summary>
	        /// 实体类型
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 扩展参数
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
