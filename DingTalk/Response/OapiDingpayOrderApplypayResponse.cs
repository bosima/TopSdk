using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingpayOrderApplypayResponse.
    /// </summary>
    public class OapiDingpayOrderApplypayResponse : DingTalkResponse
    {
        /// <summary>
        /// 钉钉错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误文案
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public OrderApplyPayOpenResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OrderApplyPayOpenResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OrderApplyPayOpenResponseDomain : TopObject
{
	        /// <summary>
	        /// 收银台需要的订单参数
	        /// </summary>
	        [XmlElement("orderStr")]
	        public string OrderStr { get; set; }
}

    }
}
