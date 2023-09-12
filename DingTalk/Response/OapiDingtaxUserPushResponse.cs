using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingtaxUserPushResponse.
    /// </summary>
    public class OapiDingtaxUserPushResponse : DingTalkResponse
    {
        /// <summary>
        /// 参数错误
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 参数错误
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 是否推送成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 服务是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
