using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripMonthbillUrlGetResponse.
    /// </summary>
    public class OapiAlitripBtripMonthbillUrlGetResponse : DingTalkResponse
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
        /// 结果对象
        /// </summary>
        [XmlArray("module")]
        [XmlArrayItem("open_account_rs")]
        public List<OpenAccountRsDomain> Module { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenAccountRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenAccountRsDomain : TopObject
{
	        /// <summary>
	        /// 账期结束时间
	        /// </summary>
	        [XmlElement("end_date")]
	        public string EndDate { get; set; }
	
	        /// <summary>
	        /// 账期开始时间
	        /// </summary>
	        [XmlElement("start_date")]
	        public string StartDate { get; set; }
	
	        /// <summary>
	        /// json数据下载链接，通过HttpClient 获取 并GBK格式解析，链接五分钟有效期
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

    }
}
