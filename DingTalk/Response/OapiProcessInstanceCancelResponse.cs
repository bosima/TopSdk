using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessInstanceCancelResponse.
    /// </summary>
    public class OapiProcessInstanceCancelResponse : DingTalkResponse
    {
        /// <summary>
        /// 流程不存在code
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误提示
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 作废成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
