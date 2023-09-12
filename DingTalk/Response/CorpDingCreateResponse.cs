using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpDingCreateResponse.
    /// </summary>
    public class CorpDingCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

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

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// 错码码
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// 失败原因
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 返回结果
	        /// </summary>
	        [XmlElement("result")]
	        public CorpDingCreateResultDomain Result { get; set; }
	
	        /// <summary>
	        /// 调用结果
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
