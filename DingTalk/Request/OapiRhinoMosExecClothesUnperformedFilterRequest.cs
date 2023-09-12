using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.clothes.unperformed.filter
    /// </summary>
    public class OapiRhinoMosExecClothesUnperformedFilterRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecClothesUnperformedFilterResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Req { get; set; }

        public FilterUnPerformedClothesReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.clothes.unperformed.filter";
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
        }

	/// <summary>
/// FilterUnPerformedClothesReqDomain Data Structure.
/// </summary>
[Serializable]

public class FilterUnPerformedClothesReqDomain : TopObject
{
	        /// <summary>
	        /// 实体ID列表
	        /// </summary>
	        [XmlArray("entity_ids")]
	        [XmlArrayItem("number")]
	        public List<string> EntityIds { get; set; }
	
	        /// <summary>
	        /// 工序ID列表
	        /// </summary>
	        [XmlArray("operation_uids")]
	        [XmlArrayItem("number")]
	        public List<string> OperationUids { get; set; }
	
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
	        /// 预留参数
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
