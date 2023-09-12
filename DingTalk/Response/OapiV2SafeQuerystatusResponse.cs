using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiV2SafeQuerystatusResponse.
    /// </summary>
    public class OapiV2SafeQuerystatusResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码。0代表成功。
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [XmlElement("result")]
        public SafeQueryStatusResponseDomain Result { get; set; }

	/// <summary>
/// SafeQueryStatusResponseDomain Data Structure.
/// </summary>
[Serializable]

public class SafeQueryStatusResponseDomain : TopObject
{
	        /// <summary>
	        /// 是否已冻结
	        /// </summary>
	        [XmlElement("disable")]
	        public bool Disable { get; set; }
}

    }
}
