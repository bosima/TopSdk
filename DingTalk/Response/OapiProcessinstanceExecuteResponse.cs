using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessinstanceExecuteResponse.
    /// </summary>
    public class OapiProcessinstanceExecuteResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 操作结果，true为通过，false为失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
