using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAppstoreInternalOrderFinishResponse.
    /// </summary>
    public class OapiAppstoreInternalOrderFinishResponse : DingTalkResponse
    {
        /// <summary>
        /// 服务结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 服务结果描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

    }
}
