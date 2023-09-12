using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingmiRobotPushResponse.
    /// </summary>
    public class OapiDingmiRobotPushResponse : DingTalkResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 结果码描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 业务是否成功
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 服务是否调用成功。
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
