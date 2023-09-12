using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceIsopensmartreportResponse.
    /// </summary>
    public class OapiAttendanceIsopensmartreportResponse : DingTalkResponse
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
        public IsOpenSmartReportForTopVoDomain Result { get; set; }

	/// <summary>
/// IsOpenSmartReportForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class IsOpenSmartReportForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 判断企业是否开启了考勤智能报表，true表示开启
	        /// </summary>
	        [XmlElement("smart_report")]
	        public bool SmartReport { get; set; }
}

    }
}
