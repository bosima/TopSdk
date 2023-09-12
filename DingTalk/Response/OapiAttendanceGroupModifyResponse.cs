using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGroupModifyResponse.
    /// </summary>
    public class OapiAttendanceGroupModifyResponse : DingTalkResponse
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
        /// 考勤组结果
        /// </summary>
        [XmlElement("result")]
        public TopGroupVoDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TopGroupVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopGroupVoDomain : TopObject
{
	        /// <summary>
	        /// 考勤组id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 考勤组名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

    }
}
