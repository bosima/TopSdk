using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiHrmEmployeeAddresumerecordResponse.
    /// </summary>
    public class OapiHrmEmployeeAddresumerecordResponse : DingTalkResponse
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
        /// 成长记录唯一标记
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
