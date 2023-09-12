using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatScencegroupInteractivecardCallbackRegisterResponse.
    /// </summary>
    public class OapiImChatScencegroupInteractivecardCallbackRegisterResponse : DingTalkResponse
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
        /// 业务返回结果
        /// </summary>
        [XmlElement("result")]
        public InteractiveCardCallbackCreateResponseDomain Result { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// InteractiveCardCallbackCreateResponseDomain Data Structure.
/// </summary>
[Serializable]

public class InteractiveCardCallbackCreateResponseDomain : TopObject
{
	        /// <summary>
	        /// api签名密钥
	        /// </summary>
	        [XmlElement("apiSecret")]
	        public string ApiSecret { get; set; }
	
	        /// <summary>
	        /// 业务回调地址
	        /// </summary>
	        [XmlElement("callbackUrl")]
	        public string CallbackUrl { get; set; }
}

    }
}
