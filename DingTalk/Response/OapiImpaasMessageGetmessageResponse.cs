using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasMessageGetmessageResponse.
    /// </summary>
    public class OapiImpaasMessageGetmessageResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码，0表示成功，非0表示失败
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回的是加密信息，需要开发者自行解密，解密完的内容看示例
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
