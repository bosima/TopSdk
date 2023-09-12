using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiOpenencryptUpdateconfigResponse.
    /// </summary>
    public class OapiOpenencryptUpdateconfigResponse : DingTalkResponse
    {
        /// <summary>
        /// 内部错误
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 一般是空字符串
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 接口状态标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
