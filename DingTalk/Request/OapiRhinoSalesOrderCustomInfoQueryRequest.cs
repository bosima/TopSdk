using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.sales.order.custom.info.query
    /// </summary>
    public class OapiRhinoSalesOrderCustomInfoQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoSalesOrderCustomInfoQueryResponse>
    {
        /// <summary>
        /// 请求体
        /// </summary>
        public string Req { get; set; }

        public OpenApiSalesOrderCustomInfoQueryReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.sales.order.custom.info.query";
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
/// OpenApiSalesOrderCustomInfoQueryReqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiSalesOrderCustomInfoQueryReqDomain : TopObject
{
	        /// <summary>
	        /// 同步的2C订单批次id
	        /// </summary>
	        [XmlElement("batch_id")]
	        public Nullable<long> BatchId { get; set; }
	
	        /// <summary>
	        /// 页码
	        /// </summary>
	        [XmlElement("page")]
	        public Nullable<long> Page { get; set; }
	
	        /// <summary>
	        /// 每页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 计划交期-查询时间开始
	        /// </summary>
	        [XmlElement("planned_delivery_time_begin")]
	        public Nullable<DateTime> PlannedDeliveryTimeBegin { get; set; }
	
	        /// <summary>
	        /// 计划交期-查询时间结束
	        /// </summary>
	        [XmlElement("planned_delivery_time_end")]
	        public Nullable<DateTime> PlannedDeliveryTimeEnd { get; set; }
	
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
