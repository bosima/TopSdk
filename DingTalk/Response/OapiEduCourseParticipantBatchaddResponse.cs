using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCourseParticipantBatchaddResponse.
    /// </summary>
    public class OapiEduCourseParticipantBatchaddResponse : DingTalkResponse
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
        /// 操作是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
