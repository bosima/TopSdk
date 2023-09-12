using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiPlatformTranslateResponse.
    /// </summary>
    public class OapiPlatformTranslateResponse : DingTalkResponse
    {
        /// <summary>
        /// 成功为0
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 翻译结果字符串
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
