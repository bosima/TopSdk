using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCourseCreateResponse.
    /// </summary>
    public class OapiEduCourseCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 课程唯一编码
        /// </summary>
        [XmlElement("course_code")]
        public string CourseCode { get; set; }

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
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
