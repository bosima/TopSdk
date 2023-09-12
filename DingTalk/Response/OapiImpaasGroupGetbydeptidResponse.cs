using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasGroupGetbydeptidResponse.
    /// </summary>
    public class OapiImpaasGroupGetbydeptidResponse : DingTalkResponse
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
        public BaseGroupInfoDomain Result { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// BaseGroupInfoDomain Data Structure.
/// </summary>
[Serializable]

public class BaseGroupInfoDomain : TopObject
{
	        /// <summary>
	        /// conversation_id
	        /// </summary>
	        [XmlElement("conversation_id")]
	        public string ConversationId { get; set; }
	
	        /// <summary>
	        /// icon
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// open_conversation_id
	        /// </summary>
	        [XmlElement("open_conversation_id")]
	        public string OpenConversationId { get; set; }
	
	        /// <summary>
	        /// owner
	        /// </summary>
	        [XmlElement("owner")]
	        public long Owner { get; set; }
	
	        /// <summary>
	        /// tag
	        /// </summary>
	        [XmlElement("tag")]
	        public long Tag { get; set; }
	
	        /// <summary>
	        /// title
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
