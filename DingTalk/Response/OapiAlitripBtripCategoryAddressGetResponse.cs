using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripCategoryAddressGetResponse.
    /// </summary>
    public class OapiAlitripBtripCategoryAddressGetResponse : DingTalkResponse
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
        /// module
        /// </summary>
        [XmlElement("result")]
        public OpenJumpInfoRsDomain Result { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenJumpInfoRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenJumpInfoRsDomain : TopObject
{
	        /// <summary>
	        /// 跳转url
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

    }
}
