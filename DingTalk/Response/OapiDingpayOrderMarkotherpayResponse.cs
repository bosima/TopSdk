using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingpayOrderMarkotherpayResponse.
    /// </summary>
    public class OapiDingpayOrderMarkotherpayResponse : DingTalkResponse
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
        public OrderMarkOtherPayOpenResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OrderMarkOtherPayOpenResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OrderMarkOtherPayOpenResponseDomain : TopObject
{
	        /// <summary>
	        /// 标记结果
	        /// </summary>
	        [XmlElement("result_map")]
	        public string ResultMap { get; set; }
}

    }
}
