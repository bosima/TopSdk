using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.order.detail.get
    /// </summary>
    public class OapiRhinoOrderDetailGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoOrderDetailGetResponse>
    {
        /// <summary>
        /// 请求体
        /// </summary>
        public string Req { get; set; }

        public OpenApiGetProductOrderDetailReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.order.detail.get";
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
/// OpenApiGetProductOrderDetailReqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiGetProductOrderDetailReqDomain : TopObject
{
	        /// <summary>
	        /// 生产订单id
	        /// </summary>
	        [XmlElement("product_order_id")]
	        public Nullable<long> ProductOrderId { get; set; }
	
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
