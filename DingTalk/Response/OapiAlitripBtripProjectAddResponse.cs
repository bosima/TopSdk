using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripProjectAddResponse.
    /// </summary>
    public class OapiAlitripBtripProjectAddResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("module")]
        public string Module { get; set; }

        /// <summary>
        /// 是否操作成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
