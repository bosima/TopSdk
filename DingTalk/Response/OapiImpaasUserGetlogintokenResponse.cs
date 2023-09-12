using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasUserGetlogintokenResponse.
    /// </summary>
    public class OapiImpaasUserGetlogintokenResponse : DingTalkResponse
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
        public GetLoginTokenRespDomain Result { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// GetLoginTokenRespDomain Data Structure.
/// </summary>
[Serializable]

public class GetLoginTokenRespDomain : TopObject
{
	        /// <summary>
	        /// expire
	        /// </summary>
	        [XmlElement("expire")]
	        public long Expire { get; set; }
	
	        /// <summary>
	        /// loginToken
	        /// </summary>
	        [XmlElement("login_token")]
	        public string LoginToken { get; set; }
}

    }
}
