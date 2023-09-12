using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRobotMessageSendotoResponse.
    /// </summary>
    public class OapiRobotMessageSendotoResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public OtoMessageSendTopResponseDomain Result { get; set; }

        /// <summary>
        /// 是否受理成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OtoMessageSendTopResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OtoMessageSendTopResponseDomain : TopObject
{
	        /// <summary>
	        /// 用于查询发送进度的唯一标识
	        /// </summary>
	        [XmlElement("process_query_key")]
	        public string ProcessQueryKey { get; set; }
}

    }
}
