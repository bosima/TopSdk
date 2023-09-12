using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.operation.condition.get
    /// </summary>
    public class OapiRhinoMosExecOperationConditionGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecOperationConditionGetResponse>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string GetClothesConditionReq { get; set; }

        public GetClothesConditionReqDomain GetClothesConditionReq_ { set { this.GetClothesConditionReq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.operation.condition.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("get_clothes_condition_req", this.GetClothesConditionReq);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("get_clothes_condition_req", this.GetClothesConditionReq);
        }

	/// <summary>
/// SourceDomain Data Structure.
/// </summary>
[Serializable]

public class SourceDomain : TopObject
{
	        /// <summary>
	        /// source_id
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// source_type
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
	        /// 实体id
	        /// </summary>
	        [XmlArray("entity_ids")]
	        [XmlArrayItem("number")]
	        public List<string> EntityIds { get; set; }
	
	        /// <summary>
	        /// 实体源
	        /// </summary>
	        [XmlElement("entity_source")]
	        public SourceDomain EntitySource { get; set; }
	
	        /// <summary>
	        /// 实体类型
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
}

	/// <summary>
/// PageDomain Data Structure.
/// </summary>
[Serializable]

public class PageDomain : TopObject
{
	        /// <summary>
	        /// 页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 开始
	        /// </summary>
	        [XmlElement("start")]
	        public Nullable<long> Start { get; set; }
}

	/// <summary>
/// GetClothesConditionReqDomain Data Structure.
/// </summary>
[Serializable]

public class GetClothesConditionReqDomain : TopObject
{
	        /// <summary>
	        /// 实体条件
	        /// </summary>
	        [XmlElement("condition")]
	        public EntityConditionDomain Condition { get; set; }
	
	        /// <summary>
	        /// 租户
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
	
	        /// <summary>
	        /// 页信息
	        /// </summary>
	        [XmlElement("page")]
	        public PageDomain Page { get; set; }
	
	        /// <summary>
	        /// 尺码
	        /// </summary>
	        [XmlArray("size_codes")]
	        [XmlArrayItem("string")]
	        public List<string> SizeCodes { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlArray("status")]
	        [XmlArrayItem("string")]
	        public List<string> Status { get; set; }
	
	        /// <summary>
	        /// 租户id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// user_id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
