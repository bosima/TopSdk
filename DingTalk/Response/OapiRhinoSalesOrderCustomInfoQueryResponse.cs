using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoSalesOrderCustomInfoQueryResponse.
    /// </summary>
    public class OapiRhinoSalesOrderCustomInfoQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 响应码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 调用信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回内容
        /// </summary>
        [XmlElement("model")]
        public OpenApiSalesOrderQueryCustomInfoResultDomain Model { get; set; }

	/// <summary>
/// OpenApiSalesOrderCustomInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiSalesOrderCustomInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 局定需求id
	        /// </summary>
	        [XmlElement("biz_id_customer_order")]
	        public string BizIdCustomerOrder { get; set; }
	
	        /// <summary>
	        /// 2C订单下单时间
	        /// </summary>
	        [XmlElement("gmt_order_create")]
	        public string GmtOrderCreate { get; set; }
	
	        /// <summary>
	        /// 2C订单计划交期时间
	        /// </summary>
	        [XmlElement("gmt_planned_delivery")]
	        public string GmtPlannedDelivery { get; set; }
	
	        /// <summary>
	        /// 2C订单制造域计划完成时间
	        /// </summary>
	        [XmlElement("gmt_planned_production_finished")]
	        public string GmtPlannedProductionFinished { get; set; }
	
	        /// <summary>
	        /// 图片链接
	        /// </summary>
	        [XmlElement("img_url")]
	        public string ImgUrl { get; set; }
	
	        /// <summary>
	        /// 对应生产订单id
	        /// </summary>
	        [XmlElement("product_order_id")]
	        public long ProductOrderId { get; set; }
	
	        /// <summary>
	        /// 开始生产时间
	        /// </summary>
	        [XmlElement("production_time")]
	        public string ProductionTime { get; set; }
	
	        /// <summary>
	        /// 数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
	
	        /// <summary>
	        /// 尺码ID
	        /// </summary>
	        [XmlElement("size_id")]
	        public long SizeId { get; set; }
	
	        /// <summary>
	        /// 尺码名称
	        /// </summary>
	        [XmlElement("size_name")]
	        public string SizeName { get; set; }
	
	        /// <summary>
	        /// 是否跳过定制（印空花）
	        /// </summary>
	        [XmlElement("skip_customized")]
	        public bool SkipCustomized { get; set; }
	
	        /// <summary>
	        /// 状态，WAIT_PRODUCTION - 待生产，PRODUCING - 生产中， CLOSED - 已关单， CANCELLED - 已取消
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

	/// <summary>
/// OpenApiSalesOrderQueryCustomInfoResultDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiSalesOrderQueryCustomInfoResultDomain : TopObject
{
	        /// <summary>
	        /// 2C订单列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("open_api_sales_order_custom_info_dto")]
	        public List<OpenApiSalesOrderCustomInfoDtoDomain> List { get; set; }
	
	        /// <summary>
	        /// 当前页数
	        /// </summary>
	        [XmlElement("page")]
	        public long Page { get; set; }
	
	        /// <summary>
	        /// 分页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 总数
	        /// </summary>
	        [XmlElement("total")]
	        public long Total { get; set; }
}

    }
}
