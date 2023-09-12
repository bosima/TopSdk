using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMicroappCustomCreateResponse.
    /// </summary>
    public class OapiMicroappCustomCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述文案
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 定制应用
        /// </summary>
        [XmlElement("result")]
        public CustomAppCreateResponseVoDomain Result { get; set; }

	/// <summary>
/// CustomAppCreateResponseVoDomain Data Structure.
/// </summary>
[Serializable]

public class CustomAppCreateResponseVoDomain : TopObject
{
	        /// <summary>
	        /// 定制应用id
	        /// </summary>
	        [XmlElement("agent_id")]
	        public long AgentId { get; set; }
	
	        /// <summary>
	        /// 定制应用key
	        /// </summary>
	        [XmlElement("custom_key")]
	        public string CustomKey { get; set; }
	
	        /// <summary>
	        /// 定制应用secret
	        /// </summary>
	        [XmlElement("custom_secret")]
	        public string CustomSecret { get; set; }
}

    }
}
