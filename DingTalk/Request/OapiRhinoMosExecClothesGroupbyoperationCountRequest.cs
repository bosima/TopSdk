using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.clothes.groupbyoperation.count
    /// </summary>
    public class OapiRhinoMosExecClothesGroupbyoperationCountRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecClothesGroupbyoperationCountResponse>
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        public string Request { get; set; }

        public ClothesGroupByOperationConditionDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.clothes.groupbyoperation.count";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// ClothesGroupByOperationConditionDomain Data Structure.
/// </summary>
[Serializable]

public class ClothesGroupByOperationConditionDomain : TopObject
{
	        /// <summary>
	        /// 工序生效条件(ACTIVE/INACTIVE)
	        /// </summary>
	        [XmlElement("active_condition")]
	        public string ActiveCondition { get; set; }
	
	        /// <summary>
	        /// 衣服生产状态列表
	        /// </summary>
	        [XmlArray("clothes_status_list")]
	        [XmlArrayItem("string")]
	        public List<string> ClothesStatusList { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
	
	        /// <summary>
	        /// 工序执行状态
	        /// </summary>
	        [XmlArray("perform_status_list")]
	        [XmlArrayItem("string")]
	        public List<string> PerformStatusList { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
