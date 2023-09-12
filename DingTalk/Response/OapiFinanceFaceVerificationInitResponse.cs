using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiFinanceFaceVerificationInitResponse.
    /// </summary>
    public class OapiFinanceFaceVerificationInitResponse : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public OpenFaceVerificationInitResultDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenFaceVerificationInitResultDomain Data Structure.
/// </summary>
[Serializable]

public class OpenFaceVerificationInitResultDomain : TopObject
{
	        /// <summary>
	        /// 人脸识别业务编码
	        /// </summary>
	        [XmlElement("business_id")]
	        public string BusinessId { get; set; }
	
	        /// <summary>
	        /// 人脸识别请求编码
	        /// </summary>
	        [XmlElement("request_code")]
	        public string RequestCode { get; set; }
}

    }
}
