using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCourseStartResponse.
    /// </summary>
    public class OapiEduCourseStartResponse : DingTalkResponse
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
        public StartCourseResponseDomain Result { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// StartCourseResponseDomain Data Structure.
/// </summary>
[Serializable]

public class StartCourseResponseDomain : TopObject
{
	        /// <summary>
	        /// 交互是否重用
	        /// </summary>
	        [XmlElement("is_reuse")]
	        public bool IsReuse { get; set; }
	
	        /// <summary>
	        /// 交互内容id
	        /// </summary>
	        [XmlElement("target_id")]
	        public string TargetId { get; set; }
	
	        /// <summary>
	        /// 交互目标类型
	        /// </summary>
	        [XmlElement("target_type")]
	        public long TargetType { get; set; }
}

    }
}
