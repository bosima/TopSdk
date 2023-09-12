using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingpayOrderTerminateResponse.
    /// </summary>
    public class OapiDingpayOrderTerminateResponse : DingTalkResponse
    {
        /// <summary>
        /// 钉钉错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public OrderTerminationOpenResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OrderTerminateResultItemDomain Data Structure.
/// </summary>
[Serializable]

public class OrderTerminateResultItemDomain : TopObject
{
	        /// <summary>
	        /// 订单号
	        /// </summary>
	        [XmlElement("order_no")]
	        public string OrderNo { get; set; }
	
	        /// <summary>
	        /// 是否终止
	        /// </summary>
	        [XmlElement("terminated")]
	        public bool Terminated { get; set; }
}

	/// <summary>
/// OrderTerminationOpenResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OrderTerminationOpenResponseDomain : TopObject
{
	        /// <summary>
	        /// 终止结果列表
	        /// </summary>
	        [XmlArray("terminate_result")]
	        [XmlArrayItem("order_terminate_result_item")]
	        public List<OrderTerminateResultItemDomain> TerminateResult { get; set; }
}

    }
}
