using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.clothes.size.count
    /// </summary>
    public class OapiRhinoMosExecClothesSizeCountRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecClothesSizeCountResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Req { get; set; }

        public ClothesGroupBySizeConditionReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.clothes.size.count";
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
/// ClothesGroupBySizeConditionReqDomain Data Structure.
/// </summary>
[Serializable]

public class ClothesGroupBySizeConditionReqDomain : TopObject
{
	        /// <summary>
	        /// 衣服状态列表
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
