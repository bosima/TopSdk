using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAppstoreGoodsQueryResponse.
    /// </summary>
    public class OapiAppstoreGoodsQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        [XmlElement("goods_info")]
        public OpenGoodsVoDomain GoodsInfo { get; set; }

	/// <summary>
/// OpenGoodsItemCycVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenGoodsItemCycVoDomain : TopObject
{
	        /// <summary>
	        /// 周期别名
	        /// </summary>
	        [XmlElement("alias_name")]
	        public string AliasName { get; set; }
	
	        /// <summary>
	        /// 订购周期数量
	        /// </summary>
	        [XmlElement("cyc_num")]
	        public long CycNum { get; set; }
	
	        /// <summary>
	        /// 订购周期单位
	        /// </summary>
	        [XmlElement("cyc_unit")]
	        public long CycUnit { get; set; }
}

	/// <summary>
/// OpenGoodsItemVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenGoodsItemVoDomain : TopObject
{
	        /// <summary>
	        /// 是否试用
	        /// </summary>
	        [XmlElement("is_try_outs")]
	        public bool IsTryOuts { get; set; }
	
	        /// <summary>
	        /// 规格码
	        /// </summary>
	        [XmlElement("item_code")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 周期列表
	        /// </summary>
	        [XmlArray("item_cyc_list")]
	        [XmlArrayItem("open_goods_item_cyc_vo")]
	        public List<OpenGoodsItemCycVoDomain> ItemCycList { get; set; }
	
	        /// <summary>
	        /// 规格名称
	        /// </summary>
	        [XmlElement("item_name")]
	        public string ItemName { get; set; }
	
	        /// <summary>
	        /// 最大购买人数
	        /// </summary>
	        [XmlElement("max_num")]
	        public long MaxNum { get; set; }
	
	        /// <summary>
	        /// 最小购买人数
	        /// </summary>
	        [XmlElement("min_num")]
	        public long MinNum { get; set; }
}

	/// <summary>
/// OpenGoodsVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenGoodsVoDomain : TopObject
{
	        /// <summary>
	        /// 规格列表
	        /// </summary>
	        [XmlArray("item_list")]
	        [XmlArrayItem("open_goods_item_vo")]
	        public List<OpenGoodsItemVoDomain> ItemList { get; set; }
	
	        /// <summary>
	        /// 商品名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

    }
}
