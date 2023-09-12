using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripAddressGetResponse.
    /// </summary>
    public class OapiAlitripBtripAddressGetResponse : DingTalkResponse
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
        [XmlElement("result")]
        public OpenApiJumpInfoRsDomain Result { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenApiJumpInfoRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiJumpInfoRsDomain : TopObject
{
	        /// <summary>
	        /// 访问地址
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

    }
}
