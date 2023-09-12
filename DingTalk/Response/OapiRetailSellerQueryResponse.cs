using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRetailSellerQueryResponse.
    /// </summary>
    public class OapiRetailSellerQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 卖家列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("seller_dto")]
        public List<SellerDtoDomain> Result { get; set; }

        /// <summary>
        /// 调用成功于否
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// SellerDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SellerDtoDomain : TopObject
{
	        /// <summary>
	        /// 卖家ID
	        /// </summary>
	        [XmlElement("seller_id")]
	        public long SellerId { get; set; }
	
	        /// <summary>
	        /// 卖家nick
	        /// </summary>
	        [XmlElement("seller_nick")]
	        public string SellerNick { get; set; }
	
	        /// <summary>
	        /// 天猫店|淘宝店
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

    }
}
