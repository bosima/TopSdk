using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasUserAddprofileResponse.
    /// </summary>
    public class OapiImpaasUserAddprofileResponse : DingTalkResponse
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
        public AddProfileRespDomain Result { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// AddProfileRespDomain Data Structure.
/// </summary>
[Serializable]

public class AddProfileRespDomain : TopObject
{
	        /// <summary>
	        /// imOpenId
	        /// </summary>
	        [XmlElement("im_openid")]
	        public string ImOpenid { get; set; }
}

    }
}
