using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.clothes.batch.unscrap
    /// </summary>
    public class OapiRhinoMosExecClothesBatchUnscrapRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecClothesBatchUnscrapResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string BatchClothesPerformReq { get; set; }

        public BatchClothesPerformBaseReqDomain BatchClothesPerformReq_ { set { this.BatchClothesPerformReq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.clothes.batch.unscrap";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("batch_clothes_perform_req", this.BatchClothesPerformReq);
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
/// BatchClothesPerformBaseReqDomain Data Structure.
/// </summary>
[Serializable]

public class BatchClothesPerformBaseReqDomain : TopObject
{
	        /// <summary>
	        /// 实体列表
	        /// </summary>
	        [XmlArray("entity_ids")]
	        [XmlArrayItem("number")]
	        public List<string> EntityIds { get; set; }
	
	        /// <summary>
	        /// 扩展属性
	        /// </summary>
	        [XmlElement("ext_properties")]
	        public string ExtProperties { get; set; }
	
	        /// <summary>
	        /// 订单ID
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
