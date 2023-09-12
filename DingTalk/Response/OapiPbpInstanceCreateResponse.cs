using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiPbpInstanceCreateResponse.
    /// </summary>
    public class OapiPbpInstanceCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 业务实例id
        /// </summary>
        [XmlElement("biz_inst_id")]
        public string BizInstId { get; set; }

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
