using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.operation.condition.inactive
    /// </summary>
    public class OapiRhinoMosExecOperationConditionInactiveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecOperationConditionInactiveResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string InactiveOperationReq { get; set; }

        public InactiveOperationByConditionReqDomain InactiveOperationReq_ { set { this.InactiveOperationReq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.operation.condition.inactive";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("inactive_operation_req", this.InactiveOperationReq);
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
	        /// source id
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// source type
	        /// </summary>
	        [XmlElement("source_type")]
	        public string SourceType { get; set; }
}

	/// <summary>
/// OperationConditionDomain Data Structure.
/// </summary>
[Serializable]

public class OperationConditionDomain : TopObject
{
	        /// <summary>
	        /// 记录id
	        /// </summary>
	        [XmlArray("ids")]
	        [XmlArrayItem("number")]
	        public List<string> Ids { get; set; }
	
	        /// <summary>
	        /// 来源
	        /// </summary>
	        [XmlElement("source")]
	        public SourceDomain Source { get; set; }
}

	/// <summary>
/// InactiveOperationByConditionReqDomain Data Structure.
/// </summary>
[Serializable]

public class InactiveOperationByConditionReqDomain : TopObject
{
	        /// <summary>
	        /// 条件
	        /// </summary>
	        [XmlElement("condition")]
	        public OperationConditionDomain Condition { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
	
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
