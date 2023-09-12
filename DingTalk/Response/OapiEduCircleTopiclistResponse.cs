using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCircleTopiclistResponse.
    /// </summary>
    public class OapiEduCircleTopiclistResponse : DingTalkResponse
    {
        /// <summary>
        /// 1
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
        [XmlArray("result")]
        [XmlArrayItem("open_circle_topic_response")]
        public List<OpenCircleTopicResponseDomain> Result { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenCircleTopicResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCircleTopicResponseDomain : TopObject
{
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("album_media_id")]
	        public string AlbumMediaId { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("init_topic")]
	        public bool InitTopic { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("post_count")]
	        public long PostCount { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("topic_id")]
	        public long TopicId { get; set; }
}

    }
}
