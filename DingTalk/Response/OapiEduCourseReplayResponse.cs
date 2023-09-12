using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCourseReplayResponse.
    /// </summary>
    public class OapiEduCourseReplayResponse : DingTalkResponse
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
        public ReplayCourseResponseDomain Result { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ReplayCourseResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ReplayCourseResponseDomain : TopObject
{
	        /// <summary>
	        /// 回放url列表
	        /// </summary>
	        [XmlArray("replay_urls")]
	        [XmlArrayItem("string")]
	        public List<string> ReplayUrls { get; set; }
	
	        /// <summary>
	        /// 是否可回放
	        /// </summary>
	        [XmlElement("replayable")]
	        public bool Replayable { get; set; }
}

    }
}
