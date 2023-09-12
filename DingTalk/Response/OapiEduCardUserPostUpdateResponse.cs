using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCardUserPostUpdateResponse.
    /// </summary>
    public class OapiEduCardUserPostUpdateResponse : DingTalkResponse
    {
        /// <summary>
        /// 无效参数
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("result")]
        public UpdatePostResponseDomain Result { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// UpdatePostResponseDomain Data Structure.
/// </summary>
[Serializable]

public class UpdatePostResponseDomain : TopObject
{
	        /// <summary>
	        /// 动态ID
	        /// </summary>
	        [XmlElement("post_id")]
	        public long PostId { get; set; }
}

    }
}
