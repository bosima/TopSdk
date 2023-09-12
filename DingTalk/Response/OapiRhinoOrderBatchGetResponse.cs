using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoOrderBatchGetResponse.
    /// </summary>
    public class OapiRhinoOrderBatchGetResponse : DingTalkResponse
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
        public OpenApiBatchGetProductOrderResultDomain Model { get; set; }

	/// <summary>
/// OpenApiProductOrderDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiProductOrderDtoDomain : TopObject
{
	        /// <summary>
	        /// 实际完成时间
	        /// </summary>
	        [XmlElement("actual_finish_time")]
	        public string ActualFinishTime { get; set; }
	
	        /// <summary>
	        /// 实际开始时间
	        /// </summary>
	        [XmlElement("actual_start_time")]
	        public string ActualStartTime { get; set; }
	
	        /// <summary>
	        /// 数字工艺品类id
	        /// </summary>
	        [XmlElement("biz_id_dtech_category")]
	        public string BizIdDtechCategory { get; set; }
	
	        /// <summary>
	        /// 数字工艺品类名称
	        /// </summary>
	        [XmlElement("biz_id_dtech_category_name")]
	        public string BizIdDtechCategoryName { get; set; }
	
	        /// <summary>
	        /// 数字工艺包id
	        /// </summary>
	        [XmlElement("biz_id_dtech_pkg")]
	        public string BizIdDtechPkg { get; set; }
	
	        /// <summary>
	        /// 颜色id
	        /// </summary>
	        [XmlElement("color_id")]
	        public string ColorId { get; set; }
	
	        /// <summary>
	        /// 颜色名称
	        /// </summary>
	        [XmlElement("color_name")]
	        public string ColorName { get; set; }
	
	        /// <summary>
	        /// 商家货号
	        /// </summary>
	        [XmlElement("goods_no")]
	        public string GoodsNo { get; set; }
	
	        /// <summary>
	        /// 主键id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 订单BP号
	        /// </summary>
	        [XmlElement("number")]
	        public string Number { get; set; }
	
	        /// <summary>
	        /// 订单创建时间
	        /// </summary>
	        [XmlElement("order_create_time")]
	        public string OrderCreateTime { get; set; }
	
	        /// <summary>
	        /// 计划完成时间
	        /// </summary>
	        [XmlElement("plan_finish_time")]
	        public string PlanFinishTime { get; set; }
	
	        /// <summary>
	        /// 计划开始时间
	        /// </summary>
	        [XmlElement("plan_start_time")]
	        public string PlanStartTime { get; set; }
	
	        /// <summary>
	        /// 采购订单id
	        /// </summary>
	        [XmlElement("purchase_order_id")]
	        public string PurchaseOrderId { get; set; }
	
	        /// <summary>
	        /// TRADE/DCC/TRAIN - 订单来源
	        /// </summary>
	        [XmlElement("source")]
	        public string Source { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 款号
	        /// </summary>
	        [XmlElement("style_code")]
	        public string StyleCode { get; set; }
	
	        /// <summary>
	        /// 款式id
	        /// </summary>
	        [XmlElement("style_id")]
	        public long StyleId { get; set; }
	
	        /// <summary>
	        /// 款式图片
	        /// </summary>
	        [XmlElement("style_img")]
	        public string StyleImg { get; set; }
	
	        /// <summary>
	        /// 款式名称
	        /// </summary>
	        [XmlElement("style_name")]
	        public string StyleName { get; set; }
	
	        /// <summary>
	        /// 租户id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 总数量
	        /// </summary>
	        [XmlElement("total_quantity")]
	        public long TotalQuantity { get; set; }
}

	/// <summary>
/// OpenApiBatchGetProductOrderResultDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiBatchGetProductOrderResultDomain : TopObject
{
	        /// <summary>
	        /// 列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("open_api_product_order_dto")]
	        public List<OpenApiProductOrderDtoDomain> List { get; set; }
}

    }
}
