using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiNewmanufacturerOrderGetResponse.
    /// </summary>
    public class OapiNewmanufacturerOrderGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误编码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("model")]
        public ProductOrderDtoDomain Model { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }

	/// <summary>
/// ProductOrderDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ProductOrderDtoDomain : TopObject
{
	        /// <summary>
	        /// 订单编码
	        /// </summary>
	        [XmlElement("number")]
	        public string Number { get; set; }
	
	        /// <summary>
	        /// 订单状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

    }
}
