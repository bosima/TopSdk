using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiFinanceLoanNotifyCreditResponse.
    /// </summary>
    public class OapiFinanceLoanNotifyCreditResponse : DingTalkResponse
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
        /// 结果模型
        /// </summary>
        [XmlElement("result")]
        public OpenCommonResultDomain Result { get; set; }

        /// <summary>
        /// true 成功，false 异常
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenCommonResultDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCommonResultDomain : TopObject
{
	        /// <summary>
	        /// 结果：Y 成功, N 失败
	        /// </summary>
	        [XmlElement("result")]
	        public string Result { get; set; }
}

    }
}
