using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCustomerserviceStatusGetResponse.
    /// </summary>
    public class OapiCustomerserviceStatusGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 调用错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 查询企业是否开通客服 true已开通  false未开通
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 服务调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
