using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.sales.order.custom.info.status.change
    /// </summary>
    public class OapiRhinoSalesOrderCustomInfoStatusChangeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoSalesOrderCustomInfoStatusChangeResponse>
    {
        /// <summary>
        /// 请求提体
        /// </summary>
        public string SalesOrderCustomInfoChangeReq { get; set; }

        public OpenApiCustomOrderChangeReqDomain SalesOrderCustomInfoChangeReq_ { set { this.SalesOrderCustomInfoChangeReq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.sales.order.custom.info.status.change";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("sales_order_custom_info_change_req", this.SalesOrderCustomInfoChangeReq);
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
/// OpenApiCustomOrderChangeReqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiCustomOrderChangeReqDomain : TopObject
{
	        /// <summary>
	        /// 2C订单id
	        /// </summary>
	        [XmlElement("biz_id_customer_order")]
	        public string BizIdCustomerOrder { get; set; }
	
	        /// <summary>
	        /// 2C订单状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
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
