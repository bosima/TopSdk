using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoOrderDetailGetResponse.
    /// </summary>
    public class OapiRhinoOrderDetailGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 钉钉响应码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 响应消息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("model")]
        public ModelDomain Model { get; set; }

	/// <summary>
/// OpenApiProductOrderDetailDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiProductOrderDetailDtoDomain : TopObject
{
	        /// <summary>
	        /// 主键id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 生产订单id
	        /// </summary>
	        [XmlElement("product_order_id")]
	        public long ProductOrderId { get; set; }
	
	        /// <summary>
	        /// 数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
	
	        /// <summary>
	        /// 尺码id
	        /// </summary>
	        [XmlElement("size_id")]
	        public long SizeId { get; set; }
	
	        /// <summary>
	        /// 尺码名称
	        /// </summary>
	        [XmlElement("size_name")]
	        public string SizeName { get; set; }
	
	        /// <summary>
	        /// 租户id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
}

	/// <summary>
/// ModelDomain Data Structure.
/// </summary>
[Serializable]

public class ModelDomain : TopObject
{
	        /// <summary>
	        /// 细码列表
	        /// </summary>
	        [XmlArray("detail_list")]
	        [XmlArrayItem("open_api_product_order_detail_dto")]
	        public List<OpenApiProductOrderDetailDtoDomain> DetailList { get; set; }
}

    }
}
