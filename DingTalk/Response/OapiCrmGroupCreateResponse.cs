using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCrmGroupCreateResponse.
    /// </summary>
    public class OapiCrmGroupCreateResponse : DingTalkResponse
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
        /// 群cid信息
        /// </summary>
        [XmlElement("result")]
        public CreateGroupResponseDomain Result { get; set; }

	/// <summary>
/// CreateGroupResponseDomain Data Structure.
/// </summary>
[Serializable]

public class CreateGroupResponseDomain : TopObject
{
	        /// <summary>
	        /// 加密的群cid
	        /// </summary>
	        [XmlElement("cid")]
	        public string Cid { get; set; }
}

    }
}
