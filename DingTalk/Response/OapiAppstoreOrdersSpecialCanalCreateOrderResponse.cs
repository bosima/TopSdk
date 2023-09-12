using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAppstoreOrdersSpecialCanalCreateOrderResponse.
    /// </summary>
    public class OapiAppstoreOrdersSpecialCanalCreateOrderResponse : DingTalkResponse
    {
        /// <summary>
        /// 钉钉订单id
        /// </summary>
        [XmlElement("ding_order_id")]
        public string DingOrderId { get; set; }

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

    }
}
