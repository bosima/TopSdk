using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCircleEnworkUpdateResponse.
    /// </summary>
    public class OapiCircleEnworkUpdateResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 响应信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 响应结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
