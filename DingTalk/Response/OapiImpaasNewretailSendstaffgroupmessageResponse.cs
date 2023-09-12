using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasNewretailSendstaffgroupmessageResponse.
    /// </summary>
    public class OapiImpaasNewretailSendstaffgroupmessageResponse : DingTalkResponse
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
        /// 返回结果taskid
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }

    }
}
