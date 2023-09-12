using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripReimbursementAppstatusSyncResponse.
    /// </summary>
    public class OapiAlitripBtripReimbursementAppstatusSyncResponse : DingTalkResponse
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
        /// 结果模型
        /// </summary>
        [XmlElement("module")]
        public long Module { get; set; }

    }
}
