using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripProjectDeleteResponse.
    /// </summary>
    public class OapiAlitripBtripProjectDeleteResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("module")]
        public bool Module { get; set; }

        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
