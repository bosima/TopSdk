using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserCountResponse.
    /// </summary>
    public class OapiUserCountResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public CountUserResponseDomain Result { get; set; }

	/// <summary>
/// CountUserResponseDomain Data Structure.
/// </summary>
[Serializable]

public class CountUserResponseDomain : TopObject
{
	        /// <summary>
	        /// 员工数量
	        /// </summary>
	        [XmlElement("count")]
	        public long Count { get; set; }
}

    }
}
