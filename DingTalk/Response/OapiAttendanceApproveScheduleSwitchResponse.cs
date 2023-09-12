using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceApproveScheduleSwitchResponse.
    /// </summary>
    public class OapiAttendanceApproveScheduleSwitchResponse : DingTalkResponse
    {
        /// <summary>
        /// 0代表成功，其他代表失败
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

    }
}
