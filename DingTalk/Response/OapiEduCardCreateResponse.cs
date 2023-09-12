using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCardCreateResponse.
    /// </summary>
    public class OapiEduCardCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// errorcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errormessage
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public CreateCardResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// CreateCardResponseDomain Data Structure.
/// </summary>
[Serializable]

public class CreateCardResponseDomain : TopObject
{
	        /// <summary>
	        /// 卡片ID
	        /// </summary>
	        [XmlElement("cardid")]
	        public long Cardid { get; set; }
}

    }
}
