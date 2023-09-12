using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiHrmEmployeeDelresumerecordResponse.
    /// </summary>
    public class OapiHrmEmployeeDelresumerecordResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误code
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误提示
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

    }
}
