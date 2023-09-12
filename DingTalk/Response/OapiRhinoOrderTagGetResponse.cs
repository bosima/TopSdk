using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoOrderTagGetResponse.
    /// </summary>
    public class OapiRhinoOrderTagGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 响应码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("model")]
        public OrderTagDtoDomain Model { get; set; }

	/// <summary>
/// OrderTagDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OrderTagDtoDomain : TopObject
{
	        /// <summary>
	        /// bom是否ready
	        /// </summary>
	        [XmlElement("bom_ready")]
	        public bool BomReady { get; set; }
	
	        /// <summary>
	        /// 是否为2C订单
	        /// </summary>
	        [XmlElement("customize_order")]
	        public bool CustomizeOrder { get; set; }
	
	        /// <summary>
	        /// embroidery是否ready
	        /// </summary>
	        [XmlElement("embroidery_ready")]
	        public bool EmbroideryReady { get; set; }
	
	        /// <summary>
	        /// 商家货号
	        /// </summary>
	        [XmlElement("goods_no")]
	        public string GoodsNo { get; set; }
	
	        /// <summary>
	        /// 唛架包是否ready
	        /// </summary>
	        [XmlElement("marker_ready")]
	        public bool MarkerReady { get; set; }
	
	        /// <summary>
	        /// 是否不需要BOM,除非明确设置为true，否则均为false
	        /// </summary>
	        [XmlElement("no_bom")]
	        public bool NoBom { get; set; }
	
	        /// <summary>
	        /// 是否不需要GSD,除非明确设置为true，否则均为false
	        /// </summary>
	        [XmlElement("no_gsd")]
	        public bool NoGsd { get; set; }
	
	        /// <summary>
	        /// 是否不需要laser,除非明确设置为true，否则均为false
	        /// </summary>
	        [XmlElement("no_laser")]
	        public bool NoLaser { get; set; }
	
	        /// <summary>
	        /// 是否不需要唛架,除非明确设置为true，否则均为false
	        /// </summary>
	        [XmlElement("no_marker")]
	        public bool NoMarker { get; set; }
	
	        /// <summary>
	        /// 是否需要跳过sap,除非明确设置为true,否则均不跳过
	        /// </summary>
	        [XmlElement("skip_sap")]
	        public bool SkipSap { get; set; }
	
	        /// <summary>
	        /// 是否跳过供应链相关,除非明确设置为true，否则均不跳过
	        /// </summary>
	        [XmlElement("skip_supply_chain")]
	        public bool SkipSupplyChain { get; set; }
}

    }
}
