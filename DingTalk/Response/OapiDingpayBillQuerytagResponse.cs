using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingpayBillQuerytagResponse.
    /// </summary>
    public class OapiDingpayBillQuerytagResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
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
        public BillTagQueryOpenResponseDomain Result { get; set; }

	/// <summary>
/// BillTagQueryOpenResponseDomain Data Structure.
/// </summary>
[Serializable]

public class BillTagQueryOpenResponseDomain : TopObject
{
	        /// <summary>
	        /// 标签列表
	        /// </summary>
	        [XmlArray("tags")]
	        [XmlArrayItem("string")]
	        public List<string> Tags { get; set; }
}

    }
}
