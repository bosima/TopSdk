using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiFinanceFaceVerificationQueryResponse.
    /// </summary>
    public class OapiFinanceFaceVerificationQueryResponse : DingTalkResponse
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
        /// 查询结果
        /// </summary>
        [XmlElement("result")]
        public OpenFaceVerificationQueryResultDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenFaceVerificationQueryResultDomain Data Structure.
/// </summary>
[Serializable]

public class OpenFaceVerificationQueryResultDomain : TopObject
{
	        /// <summary>
	        /// 人脸照片，BASE64编码
	        /// </summary>
	        [XmlElement("alive_photo")]
	        public string AlivePhoto { get; set; }
}

    }
}
