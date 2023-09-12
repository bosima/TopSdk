using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceFaceRecognitionResponse.
    /// </summary>
    public class OapiAttendanceFaceRecognitionResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码，0代表成功
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// demo
        /// </summary>
        [XmlElement("result")]
        public TopUserInfoVODomain Result { get; set; }

	/// <summary>
/// TopUserInfoVODomain Data Structure.
/// </summary>
[Serializable]

public class TopUserInfoVODomain : TopObject
{
	        /// <summary>
	        /// 识别出来的员工userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
