using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAtsJobDeliverAddResponse.
    /// </summary>
    public class OapiAtsJobDeliverAddResponse : DingTalkResponse
    {
        /// <summary>
        /// 投递id
        /// </summary>
        [XmlElement("deliver_id")]
        public string DeliverId { get; set; }

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

    }
}
