using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRetailSellerOrgCheckResponse.
    /// </summary>
    public class OapiRetailSellerOrgCheckResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 是否绑定
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
