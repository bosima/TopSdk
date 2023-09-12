using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAtsEvaluateJobmatchStartResponse.
    /// </summary>
    public class OapiAtsEvaluateJobmatchStartResponse : DingTalkResponse
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
        /// 钉钉招聘系统中的测评id
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
