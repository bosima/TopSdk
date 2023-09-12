using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiV2UserCreateResponse.
    /// </summary>
    public class OapiV2UserCreateResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public UserCreateResponseDomain Result { get; set; }

	/// <summary>
/// UserCreateResponseDomain Data Structure.
/// </summary>
[Serializable]

public class UserCreateResponseDomain : TopObject
{
	        /// <summary>
	        /// 员工唯一id
	        /// </summary>
	        [XmlElement("unionId")]
	        public string UnionId { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
