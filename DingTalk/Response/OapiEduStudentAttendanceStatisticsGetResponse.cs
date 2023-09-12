using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduStudentAttendanceStatisticsGetResponse.
    /// </summary>
    public class OapiEduStudentAttendanceStatisticsGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误编码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public GetStudentAttendanceStatisticsResponseDomain Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// GetStudentAttendanceStatisticsResponseDomain Data Structure.
/// </summary>
[Serializable]

public class GetStudentAttendanceStatisticsResponseDomain : TopObject
{
	        /// <summary>
	        /// 数据(key:统计项名称，value: 统计数量)
	        /// </summary>
	        [XmlElement("data")]
	        public string Data { get; set; }
}

    }
}
