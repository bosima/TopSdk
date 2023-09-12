using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduUserAuthGetResponse.
    /// </summary>
    public class OapiEduUserAuthGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码。0代表成功。
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 业务返回结果
        /// </summary>
        [XmlElement("result")]
        public UserGetRequestDomain Result { get; set; }

	/// <summary>
/// UserGetRequestDomain Data Structure.
/// </summary>
[Serializable]

public class UserGetRequestDomain : TopObject
{
	        /// <summary>
	        /// 是否实名认证
	        /// </summary>
	        [XmlElement("real_authed")]
	        public bool RealAuthed { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
