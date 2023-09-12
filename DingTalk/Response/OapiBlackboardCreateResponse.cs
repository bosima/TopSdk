using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiBlackboardCreateResponse.
    /// </summary>
    public class OapiBlackboardCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 请求失败返回的错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 请求失败返回的错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// success为true时，该值不为空，否则值为空
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 本次调用是否成功，该值为false时，根据errcode和errMsg排查失败原因
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
