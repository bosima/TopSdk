using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmSmsSendforpayslipResponse.
    /// </summary>
    public class OapiSmartworkHrmSmsSendforpayslipResponse : DingTalkResponse
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
        /// 是否成功
        /// </summary>
        [XmlElement("result")]
        public SendSmsMessageResultDomain Result { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// SendSmsMessageResultDomain Data Structure.
/// </summary>
[Serializable]

public class SendSmsMessageResultDomain : TopObject
{
	        /// <summary>
	        /// 失败的userids
	        /// </summary>
	        [XmlArray("failed_userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> FailedUseridList { get; set; }
	
	        /// <summary>
	        /// 无效的userids
	        /// </summary>
	        [XmlArray("invalid_userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> InvalidUseridList { get; set; }
	
	        /// <summary>
	        /// 成功的userids
	        /// </summary>
	        [XmlArray("success_userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> SuccessUseridList { get; set; }
}

    }
}
