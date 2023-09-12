using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiFileUploadTransactionResponse.
    /// </summary>
    public class OapiFileUploadTransactionResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 文件存储id
        /// </summary>
        [XmlElement("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// upload_id
        /// </summary>
        [XmlElement("upload_id")]
        public string UploadId { get; set; }

    }
}
