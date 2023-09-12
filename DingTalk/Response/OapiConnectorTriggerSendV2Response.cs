using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiConnectorTriggerSendV2Response.
    /// </summary>
    public class OapiConnectorTriggerSendV2Response : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public TriggerMsgResponseDomain Result { get; set; }

	/// <summary>
/// TriggerMsgResponseDomain Data Structure.
/// </summary>
[Serializable]

public class TriggerMsgResponseDomain : TopObject
{
	        /// <summary>
	        /// 请求ID
	        /// </summary>
	        [XmlElement("request_id")]
	        public string RequestId { get; set; }
}

    }
}
