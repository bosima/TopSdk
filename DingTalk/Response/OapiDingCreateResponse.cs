using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingCreateResponse.
    /// </summary>
    public class OapiDingCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 错码码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public CorpDingCreateResultDomain Result { get; set; }

	/// <summary>
/// CorpDingCreateResultDomain Data Structure.
/// </summary>
[Serializable]

public class CorpDingCreateResultDomain : TopObject
{
	        /// <summary>
	        /// invalidUser
	        /// </summary>
	        [XmlArray("invalid_users")]
	        [XmlArrayItem("string")]
	        public List<string> InvalidUsers { get; set; }
	
	        /// <summary>
	        /// openDingId
	        /// </summary>
	        [XmlElement("open_ding_id")]
	        public string OpenDingId { get; set; }
}

    }
}
