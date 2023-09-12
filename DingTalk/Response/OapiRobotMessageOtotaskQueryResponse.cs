using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRobotMessageOtotaskQueryResponse.
    /// </summary>
    public class OapiRobotMessageOtotaskQueryResponse : DingTalkResponse
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
	        /// READ 已读，UNREAD 未读
	        /// </summary>
	        [XmlElement("read_status")]
	        public string ReadStatus { get; set; }
	
	        /// <summary>
	        /// 消息已读时间戳，单位：秒
	        /// </summary>
	        [XmlElement("read_timestamp")]
	        public long ReadTimestamp { get; set; }
	
	        /// <summary>
	        /// 发送结果码，只有SUCCESS为成功
	        /// </summary>
	        [XmlElement("send_status")]
	        public string SendStatus { get; set; }
}

    }
}
