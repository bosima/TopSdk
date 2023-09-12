using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiContactRolevisibilityUpdateResponse.
    /// </summary>
    public class OapiContactRolevisibilityUpdateResponse : DingTalkResponse
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
        /// true: 接口调用成功  false: 接口调用失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
