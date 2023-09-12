using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmFlexibleApplytokenResponse.
    /// </summary>
    public class OapiSmartworkHrmFlexibleApplytokenResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public FlexibleTokenVoDomain Result { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// FlexibleTokenVoDomain Data Structure.
/// </summary>
[Serializable]

public class FlexibleTokenVoDomain : TopObject
{
	        /// <summary>
	        /// 令牌
	        /// </summary>
	        [XmlElement("token")]
	        public string Token { get; set; }
}

    }
}
