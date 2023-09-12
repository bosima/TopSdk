using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCourseJoinResponse.
    /// </summary>
    public class OapiEduCourseJoinResponse : DingTalkResponse
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
        public JoinCourseResponseDomain Result { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// JoinCourseResponseDomain Data Structure.
/// </summary>
[Serializable]

public class JoinCourseResponseDomain : TopObject
{
	        /// <summary>
	        /// 加入的目标id
	        /// </summary>
	        [XmlElement("join_target_id")]
	        public string JoinTargetId { get; set; }
	
	        /// <summary>
	        /// 加入链接
	        /// </summary>
	        [XmlElement("join_url")]
	        public string JoinUrl { get; set; }
	
	        /// <summary>
	        /// 是否可加入
	        /// </summary>
	        [XmlElement("joinable")]
	        public bool Joinable { get; set; }
}

    }
}
