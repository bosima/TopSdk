using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImIntelligentCardSendResponse.
    /// </summary>
    public class OapiImIntelligentCardSendResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public SendInteractiveCardResultVoDomain Result { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// SendInteractiveCardResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class SendInteractiveCardResultVoDomain : TopObject
{
	        /// <summary>
	        /// 卡片发送结果
	        /// </summary>
	        [XmlElement("result")]
	        public bool Result { get; set; }
}

    }
}
