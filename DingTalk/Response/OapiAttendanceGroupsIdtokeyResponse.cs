using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGroupsIdtokeyResponse.
    /// </summary>
    public class OapiAttendanceGroupsIdtokeyResponse : DingTalkResponse
    {
        /// <summary>
        /// 调用失败的code
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 考勤组ID
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
