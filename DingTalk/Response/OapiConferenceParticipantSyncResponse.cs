using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiConferenceParticipantSyncResponse.
    /// </summary>
    public class OapiConferenceParticipantSyncResponse : DingTalkResponse
    {
        /// <summary>
        /// 批次号，首次上传后生成，后续批次需要在参数中带上
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

    }
}
