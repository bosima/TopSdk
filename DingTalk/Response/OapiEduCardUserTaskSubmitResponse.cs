using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCardUserTaskSubmitResponse.
    /// </summary>
    public class OapiEduCardUserTaskSubmitResponse : DingTalkResponse
    {
        /// <summary>
        /// errorcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errormsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 成功时 返回
        /// </summary>
        [XmlElement("result")]
        public CardTaskSubmitResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// CardTaskSubmitResponseDomain Data Structure.
/// </summary>
[Serializable]

public class CardTaskSubmitResponseDomain : TopObject
{
	        /// <summary>
	        /// 记录ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
}

    }
}
