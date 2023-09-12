using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGroupsKeytoidResponse.
    /// </summary>
    public class OapiAttendanceGroupsKeytoidResponse : DingTalkResponse
    {
        /// <summary>
        /// 调用错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 服务的错误返回信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 服务结果
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
